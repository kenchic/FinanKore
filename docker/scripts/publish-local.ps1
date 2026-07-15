<#
.SYNOPSIS
    Pre-publica los proyectos de FinanKore y genera el SQL de migraciones,
    dejando la carpeta `docker/` lista para copiarse a otra maquina y correr
    `docker compose up -d` sin necesidad de .NET SDK ni codigo fuente.

.DESCRIPTION
    Pasos:
      1) Verifica que se ejecuta desde la raiz del repo (donde esta `src/`).
      2) Limpia las carpetas docker/publish/ y regenera:
           - docker/publish/api/             (WebApi)
           - docker/publish/web/             (Blazor Server)
           - docker/publish/hash-password/   (util para seed admin)
      3) Genera docker/db-init/seed/migrations.sql (idempotente) con todas
         las migraciones de EF Core.
      4) Valida que los archivos criticos existan y no sean placeholders.

.NOTES
    Requisitos: .NET SDK 10.0.x y dotnet-ef 10.0.0-preview.3.25171.6.
#>

[CmdletBinding()]
param(
    [switch]$SkipEfInstall
)

$ErrorActionPreference = "Stop"

# --- Localizar la raiz del repo ----------------------------------------------------
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRoot  = Resolve-Path (Join-Path $ScriptDir "..\..")

if (-not (Test-Path (Join-Path $RepoRoot "src"))) {
    throw "No se encontro la carpeta 'src/' en '$RepoRoot'. Ejecuta este script desde la raiz del repo o ajusta la ruta."
}

$DockerDir   = Join-Path $RepoRoot "docker"
$PublishDir  = Join-Path $DockerDir "publish"
$ApiOut      = Join-Path $PublishDir "api"
$WebOut      = Join-Path $PublishDir "web"
$HashOut     = Join-Path $PublishDir "hash-password"
$SeedDir     = Join-Path $DockerDir "db-init\seed"
$MigSql      = Join-Path $SeedDir  "migrations.sql"
$HashProj    = Join-Path $DockerDir "db-init\scripts\HashPassword\HashPassword.csproj"
$ApiProj     = Join-Path $RepoRoot "src\FinanKore.WebApi\FinanKore.WebApi.csproj"
$WebProj     = Join-Path $RepoRoot "src\FinanKore.Web\FinanKore.Web.csproj"
$InfraProj   = Join-Path $RepoRoot "src\FinanKore.Infrastructure\FinanKore.Infrastructure.csproj"

$EfToolVersion = "10.0.0-preview.3.25171.6"

Write-Host ""
Write-Host "==============================================================" -ForegroundColor Cyan
Write-Host " FinanKore - Publicacion local para Docker" -ForegroundColor Cyan
Write-Host " Raiz del repo: $RepoRoot" -ForegroundColor Cyan
Write-Host "==============================================================" -ForegroundColor Cyan
Write-Host ""

# --- 0) Instalar dotnet-ef si hace falta -------------------------------------------
if (-not $SkipEfInstall) {
    Write-Host "[1/6] Verificando dotnet-ef $EfToolVersion ..." -ForegroundColor Yellow
    $efList = & dotnet tool list --global 2>$null
    if (-not ($efList | Select-String -Pattern "dotnet-ef\s+$EfToolVersion")) {
        Write-Host "  -> Instalando dotnet-ef..." -ForegroundColor Yellow
        & dotnet tool install --global dotnet-ef --version $EfToolVersion | Out-Null
    } else {
        Write-Host "  -> Ya esta instalado." -ForegroundColor Green
    }
    $env:PATH = "$env:PATH;$env:USERPROFILE\.dotnet\tools"
} else {
    Write-Host "[1/6] (omitido) Verificacion de dotnet-ef" -ForegroundColor DarkGray
}

# --- 1) Limpiar outputs previos ----------------------------------------------------
Write-Host "[2/6] Limpiando docker/publish/ ..." -ForegroundColor Yellow
if (Test-Path $PublishDir) {
    Remove-Item -Recurse -Force $PublishDir
}
New-Item -ItemType Directory -Path $ApiOut   | Out-Null
New-Item -ItemType Directory -Path $WebOut   | Out-Null
New-Item -ItemType Directory -Path $HashOut  | Out-Null
New-Item -ItemType Directory -Path $SeedDir  -Force | Out-Null

# --- 2) Publicar WebApi ------------------------------------------------------------
Write-Host "[3/6] Publicando FinanKore.WebApi -> docker/publish/api/ ..." -ForegroundColor Yellow
& dotnet publish $ApiProj -c Release -o $ApiOut /p:UseAppHost=false | Out-Null
if ($LASTEXITCODE -ne 0) { throw "Fallo dotnet publish WebApi" }
Write-Host "  -> OK" -ForegroundColor Green

# --- 3) Publicar Web --------------------------------------------------------------
Write-Host "[4/6] Publicando FinanKore.Web -> docker/publish/web/ ..." -ForegroundColor Yellow
& dotnet publish $WebProj -c Release -o $WebOut /p:UseAppHost=false | Out-Null
if ($LASTEXITCODE -ne 0) { throw "Fallo dotnet publish Web" }
Write-Host "  -> OK" -ForegroundColor Green

# --- 4) Publicar HashPassword ------------------------------------------------------
Write-Host "[5/6] Publicando HashPassword -> docker/publish/hash-password/ ..." -ForegroundColor Yellow
& dotnet publish $HashProj -c Release -o $HashOut /p:UseAppHost=false | Out-Null
if ($LASTEXITCODE -ne 0) { throw "Fallo dotnet publish HashPassword" }
Write-Host "  -> OK" -ForegroundColor Green

# --- 5) Generar migrations.sql idempotente ----------------------------------------
Write-Host "[6/6] Generando migrations.sql (idempotente) -> docker/db-init/seed/migrations.sql ..." -ForegroundColor Yellow
& dotnet ef migrations script --idempotent `
    --project $InfraProj `
    --startup-project $ApiProj `
    --output $MigSql | Out-Null
if ($LASTEXITCODE -ne 0) { throw "Fallo dotnet ef migrations script" }
Write-Host "  -> OK" -ForegroundColor Green

Write-Host ""
Write-Host "==============================================================" -ForegroundColor Green
Write-Host " Publicacion completada." -ForegroundColor Green
Write-Host ""
Write-Host " Estructura generada:" -ForegroundColor Green
Write-Host "   $ApiOut"   -ForegroundColor Green
Write-Host "   $WebOut"   -ForegroundColor Green
Write-Host "   $HashOut"  -ForegroundColor Green
Write-Host "   $MigSql"   -ForegroundColor Green
Write-Host ""
Write-Host " Siguiente paso:" -ForegroundColor Green
Write-Host "   1) cd $DockerDir" -ForegroundColor Green
Write-Host "   2) docker compose build" -ForegroundColor Green
Write-Host "   3) docker compose up -d" -ForegroundColor Green
Write-Host ""
Write-Host " Para distribuir: comprime la carpeta '$DockerDir' (sin la carpeta .git)" -ForegroundColor Green
Write-Host "   y entregala. En la maquina destino solo se necesita Docker." -ForegroundColor Green
Write-Host "==============================================================" -ForegroundColor Green

# --- 6) Validacion final: archivos criticos presentes ----------------------------
Write-Host ""
Write-Host "Validando archivos criticos ..." -ForegroundColor Yellow
$errores = @()
if (-not (Test-Path (Join-Path $ApiOut "FinanKore.WebApi.dll"))) {
    $errores += "Falta FinanKore.WebApi.dll en $ApiOut"
}
if (-not (Test-Path (Join-Path $WebOut "FinanKore.Web.dll"))) {
    $errores += "Falta FinanKore.Web.dll en $WebOut"
}
if (-not (Test-Path (Join-Path $HashOut "HashPassword.dll"))) {
    $errores += "Falta HashPassword.dll en $HashOut"
}
if (-not (Test-Path $MigSql)) {
    $errores += "Falta $MigSql"
} else {
    $contenido = Get-Content $MigSql -Raw
    if ($contenido -match "placeholder" -or $contenido.Length -lt 200) {
        $errores += "migrations.sql parece ser el placeholder o esta vacio (tamano: $($contenido.Length) bytes)"
    }
}

if ($errores.Count -gt 0) {
    Write-Host ""
    Write-Host "ATENCION: la publicacion termino con problemas:" -ForegroundColor Red
    foreach ($e in $errores) {
        Write-Host "  - $e" -ForegroundColor Red
    }
    Write-Host ""
    Write-Host "Si distribuyes esta carpeta 'docker/' asi, el contenedor db-init fallara." -ForegroundColor Red
    exit 1
} else {
    Write-Host "  -> Todo OK. La carpeta docker/ esta lista para distribuirse." -ForegroundColor Green
}
