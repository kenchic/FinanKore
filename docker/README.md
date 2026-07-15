# FinanKore - Docker Compose (edicion portable)

Orquestacion completa de la aplicacion FinanKore (Blazor Server + WebApi + SQL Server 2022) lista para distribuirse. La maquina destino solo necesita Docker: todo el codigo ya viene pre-publicado en `publish/` y las migraciones ya estan en un archivo SQL.

---

## Indice rapido

0. [Prerrequisitos](#0-prerrequisitos-todos-en-la-maquina-destino)
1. [Para el usuario final (sin codigo fuente)](#1-para-el-usuario-final-sin-codigo-fuente)
2. [Para el desarrollador (regenerar `publish/`)](#2-para-el-desarrollador-regenerar-publish)
3. [Acceso a la aplicacion](#3-acceso-a-la-aplicacion)
4. [Operaciones comunes](#4-operaciones-comunes)
5. [Troubleshooting](#5-troubleshooting)
6. [Estructura de carpetas](#6-estructura-de-carpetas)
7. [Como funciona internamente](#7-como-funciona-internamente)

---

## 0. Prerrequisitos (todos en la maquina destino)

- **Docker Desktop** instalado y corriendo.
  - Windows 10/11 con **WSL2** habilitado.
  - macOS o Linux equivalente.
- Al menos **4 GB de RAM** libres (SQL Server consume ~1.5 GB).
- **Conexion a internet** la primera vez (descarga las imagenes de Docker Hub, ~2 GB total).
- Puertos disponibles en el host: **14330** (SQL Server), **5157** (WebApi), **5175** (Web Blazor). Dentro de la red Docker, SQL Server sigue escuchando en `1433` (sin conflicto).
- **NO** se requiere .NET SDK, ni Visual Studio, ni el codigo fuente de `src/`.

---

## 1. Para el usuario final (sin codigo fuente)

La maquina destino **solo necesita Docker Desktop instalado y los pre-requisitos de arriba**. No requiere .NET, ni Visual Studio, ni el codigo fuente.

### Pasos

```powershell
# 1) Abrir PowerShell en la carpeta docker/ (descomprimir el zip y entrar)
cd docker

# 2) (Opcional) revisar/ajustar la clave del SA o puertos
notepad .env
notepad docker-compose.yml

# 3) Levantar todo. La primera vez descarga las imagenes (tarda unos minutos);
#    las siguientes veces arranca en segundos.
docker compose up -d

# 4) Ver el estado
docker compose ps
```

Resultado esperado en `docker compose ps`:

| Servicio | Estado esperado | Notas |
|---|---|---|
| `finankore-sqlserver` | `healthy` | Esperar 30-60 s al primer arranque |
| `finankore-db-init` | `Exited (0)` | Termina tras aplicar migraciones y siembras |
| `finankore-api` | `healthy` | Healthcheck TCP al puerto 8080 |
| `finankore-web` | `running` | Blazor Server no expone healthcheck por defecto |

### Que se puede configurar (opcional)

| Archivo | Para que sirve | Que ajustar ahi |
|---|---|---|
| `.env` | Variables sensibles | `MSSQL_SA_PASSWORD=...` (cambia la clave del SA) |
| `docker-compose.yml` | Orquestacion | `volumes:` (ruta del volumen en disco), `ports:` (puerto host) |

> ⚠ Si cambias `MSSQL_SA_PASSWORD` en `.env`, ten en cuenta:
>
> - Las variables de entorno del `docker-compose.yml` (`ConnectionStrings__CadenaConexion` y `ConnectionStrings__master`) se construyen a partir de `${MSSQL_SA_PASSWORD}` y **sobrescriben** cualquier valor en `appsettings.Production.json`, asi que **NO hace falta editar los `appsettings.Production.json`**.
> - Pero el contenedor de SQL Server **ya creado** sigue usando la password antigua. Para que tome la nueva, ejecuta: `docker compose down -v && docker compose up -d` (esto borra los datos de la base).

### Detener la aplicacion

```powershell
docker compose down          # detiene contenedores, MANTIENE la base de datos
docker compose down -v       # detiene contenedores y BORRA la base de datos
```

---

## 2. Para el desarrollador (regenerar `publish/`)

Cuando cambias codigo en `src/` o agregas una migracion, tienes que regenerar el contenido de `docker/publish/` y `docker/db-init/seed/migrations.sql`. Solo se hace **una vez, en tu maquina de desarrollo**.

### Pasos

```powershell
# 1) Desde la RAIZ del repo (donde esta la carpeta src/)
.\docker\scripts\publish-local.ps1

# 2) Construir las imagenes (la primera vez tarda 1-2 min, las siguientes son segundos)
cd docker
docker compose build

# 3) Levantar
docker compose up -d
```

El script `publish-local.ps1`:
- Verifica/instala `dotnet-ef` version `10.0.0-preview.3.25171.6`.
- Publica `FinanKore.WebApi` → `docker/publish/api/`
- Publica `FinanKore.Web` → `docker/publish/web/`
- Publica `HashPassword` → `docker/publish/hash-password/`
- Genera `docker/db-init/seed/migrations.sql` (idempotente, con todas las migraciones EF).
- Al final valida que los archivos criticos existan y no sean placeholders.

### Distribuir la aplicacion

Una vez regenerado `publish/`, la carpeta `docker/` esta lista para zippearse y entregarse:

```powershell
# Desde la RAIZ del repo
Compress-Archive -Path .\docker\* -DestinationPath .\finankore-docker.zip
```

En la maquina destino se descomprime el zip y se corre `docker compose up -d`.

---

## 3. Acceso a la aplicacion

| Recurso | URL / Cadena | Credenciales |
|---|---|---|
| **Web Blazor** | http://localhost:5175 | `admin@gmail.com` / `Admin123*` |
| **WebApi (OpenAPI)** | http://localhost:5157/openapi/v1.json (solo en Development) | — |
| **SQL Server (SSMS / Azure Data Studio)** | `localhost,14330` | `sa` / `Admin123*` |

Pantalla de login directa: http://localhost:5175/iniciar-sesion

---

## 4. Operaciones comunes

### a) Re-siembras rapidas (sin reiniciar la base)

```powershell
# Re-sembrar solo las categorias parametrizadas
docker compose run --rm db-init /workspace/db-init/scripts/30-seed-categorias.sh

# Re-sembrar solo el usuario admin
docker compose run --rm db-init /workspace/db-init/scripts/20-seed-admin.sh
```

> Los scripts son idempotentes: detectan si el registro ya existe y no duplican.

### b) Reset parcial del admin (eliminar y re-crear)

```powershell
docker compose run --rm db-init /workspace/db-init/scripts/40-reset-admin.sh
```

Esto borra al usuario `admin@gmail.com` y sus preferencias, y luego lo re-inserta con un nuevo hash+Salt.

### c) Reset completo de la base de datos (Borrar TODO y empezar de cero)

```powershell
docker compose down -v
docker compose up -d
```

- El parametro `-v` borra el volumen `finankore_sqlserver-data` (persistencia).
- `db-init` se vuelve a ejecutar automaticamente: aplica migraciones, inserta admin y categorias.

> Util cuando: cambiaste una migracion, modificaste el dominio, o no te gusta como quedo la base.

### d) Cambio de codigo en `src/`

En la maquina de desarrollo:

```powershell
# 1) Editas los .cs que quieras
# 2) Re-generas el publish
.\docker\scripts\publish-local.ps1

# 3) Reconstruyes solo las imagenes afectadas
cd docker
docker compose build api      # o "web" si tocaste la UI
docker compose up -d
```

La base persiste, solo se reemplaza la imagen del servicio modificado.

### e) Cambio con nueva migracion EF Core

Cuando agregas una migracion nueva en `src/FinanKore.Infrastructure/Migrations/`:

```powershell
# 1) En la maquina de desarrollo: regenerar el publish y migrations.sql
.\docker\scripts\publish-local.ps1

# 2) Distribuir la nueva carpeta docker/ (o solo el migrations.sql actualizado)

# 3) En la maquina destino: re-aplicar migraciones (solo si la migracion es ADITIVA)
docker compose run --rm db-init /workspace/db-init/scripts/10-apply-migrations.sh

#    Si la migracion rompe el esquema, hacer reset completo:
docker compose down -v
docker compose up -d
```

> Las migraciones generadas con `dotnet ef migrations script --idempotent` **no borran** tablas ni columnas huérfanas: solo crean lo que las nuevas migraciones definen. Si eliminaste una entidad, renombraste columnas o cambiaste tipos, el esquema viejo quedara en la BD; usa el reset completo para empezar de cero.

### f) Solo reiniciar servicios (la base persiste)

```powershell
docker compose restart api
docker compose restart web
docker compose restart sqlserver
```

### g) Ver logs

```powershell
# Logs en tiempo real
docker compose logs -f sqlserver
docker compose logs -f db-init
docker compose logs -f api
docker compose logs -f web

# Ultimas 100 lineas de un servicio
docker compose logs --tail=100 api
```

### h) Conectarse a la BD con SSMS o Azure Data Studio

| Campo | Valor |
|---|---|
| Server name | `localhost,14330` |
| Authentication | SQL Server Authentication |
| Login | `sa` |
| Password | `Admin123*` |
| Trust server certificate | Si |

Esquemas visibles: `Perfil`, `Finanzas`, `Proyecto`, `Configuracion`. Tablas de interes:

- `Perfil.Usuarios` - aqui vive `admin@gmail.com`
- `Configuracion.Preferencias` - preferencias del admin (Tema=Claro)
- `Finanzas.Categorias` - las 10 categorias predefinidas

### i) Ejecutar consultas SQL puntuales

```powershell
# Ver el usuario admin
docker compose exec sqlserver /opt/mssql-tools18/bin/sqlcmd `
    -S localhost -U sa -P "Admin123*" -C -No `
    -Q "SELECT Id, Correo, Nombres, Apellidos, Activo FROM Perfil.Usuarios"

# Contar categorias
docker compose exec sqlserver /opt/mssql-tools18/bin/sqlcmd `
    -S localhost -U sa -P "Admin123*" -C -No `
    -Q "SELECT COUNT(*) FROM Finanzas.Categorias"
```

---

## 5. Troubleshooting

| Sintoma | Causa probable | Solucion |
|---|---|---|
| `Login failed for user 'sa'` | Password debil o distinto a `Admin123*` | Edita `.env` y reinicia: `docker compose down -v && docker compose up -d` |
| `Cannot connect to sqlserver,1433` | SQL Server aun no healthy | Espera 30-60 s o `docker compose logs sqlserver` |
| `bind: address already in use` | Puerto 14330 del host ocupado | Cambia el mapeo en `docker-compose.yml` (ej. `"14330:1433"` por `"11433:1433"`) y reintenta |
| La Web Blazor no carga / muestra error | El contenedor `api` no levanto | `docker compose logs api` para ver el error |
| `db-init` sale con codigo distinto de 0 | Migraciones fallaron o credenciales malas | `docker compose logs db-init` para ver el detalle |
| `finankore-sqlserver` sale con `Exited (137)` | Docker mato SQL Server por falta de RAM (OOM) | El `docker-compose.yml` ya tiene `memory: 2G` para SQL Server. Si persiste, bajalo a `1G` (puede fallar con error 17120) o detiene otros contenedores pesados |
| `Error 17120, Severity 16, State 1` en `docker logs sqlserver` | SQL Server no puede asignar memoria para arrancar | Aumenta `memory:` en `docker-compose.yml` (minimo 2G para Developer edition), o cambia `MSSQL_PID: "Developer"` por `MSSQL_PID: "Express"` (mas liviano) |
| `exited (183)` y logs con `Permission denied` en `/proc/PID/maps` | SQL Server intento generar un core dump sin permisos (Docker/WSL2) | El `docker-compose.yml` ya tiene `MSSQL_DUMPCORE: "0"` y `user: "0:0"` para evitarlo. Si persiste, anade `cap_add: SYS_PTRACE` al servicio sqlserver |
| `FCB::Open failed: Could not open file F:\dbs\sh\...` y `Database 'model' cannot be opened` | La imagen `:latest` de SQL Server tiene un bug con rutas de compilacion hardcodeadas | El `docker-compose.yml` ya usa `2022-CU14-ubuntu-22.04` (version fija). Si reaparece, ejecuta `docker compose pull sqlserver` y luego `docker compose down -v && docker compose up -d` para forzar la descarga de la imagen correcta |
| Log dice `This container is running as user root. Your master database file is owned by root.` | Hay un `user: "0:0"` en el servicio sqlserver que rompe la inicializacion | El `docker-compose.yml` ya NO usa `user: "0:0"`. Si reaparece tras editar, ejecuta `docker compose down -v && docker compose up -d` para que SQL Server recree las bases con el usuario correcto |
| `finankore-api` queda en `unhealthy` aunque la app arranco | El healthcheck apuntaba a `/openapi/v1.json` que solo se expone en Development, o conflicto IPv4/IPv6 entre la app y el healthcheck | El `docker-compose.yml` ya usa `ASPNETCORE_URLS=http://0.0.0.0:8080` y `wget http://127.0.0.1:8080/`. Si reaparece, verifica que la imagen se reconstruyo con `docker compose build --no-cache api` |
| Login devuelve 401 o error de conexion | Web no encuentra a la API | Verifica `ApiBaseUrl=http://api:8080` en `web/appsettings.Production.json` |
| `migrations.sql` solo tiene un PRINT y no crea tablas | No corriste `publish-local.ps1` | En la maquina de desarrollo, ejecuta `.\docker\scripts\publish-local.ps1` y redistribuye |
| `dotnet publish` falla con error de version | SDK de .NET incorrecto | Instala .NET SDK 10.0.x (la solucion usa `net10.0`) |

---

## 6. Estructura de carpetas

```
docker/
├── docker-compose.yml              # Orquestacion de los 4 servicios
├── .env                            # Variables sensibles (NO versionar)
├── .env.example                    # Plantilla de variables
├── .dockerignore                   # Exclusiones para contexto de build
├── .gitignore                      # Ignora publish/ y migrations.sql regenerado
├── README.md                       # Este archivo
│
├── scripts/
│   └── publish-local.ps1           # SOLO DESARROLLO: genera publish/ y migrations.sql
│
├── publish/                        # GENERADO por publish-local.ps1, NO editar
│   ├── api/                        # output de dotnet publish WebApi
│   ├── web/                        # output de dotnet publish Web
│   └── hash-password/              # output de dotnet publish HashPassword
│
├── sqlserver/
│   └── conf/mssql.conf             # Configuracion del motor SQL Server
│
├── db-init/                        # Contenedor efimero: migraciones + seed
│   ├── Dockerfile                  # aspnet:10.0 + mssql-tools18 (sin SDK)
│   ├── scripts/
│   │   ├── 10-apply-migrations.sh  # Ejecuta migrations.sql (idempotente)
│   │   ├── 20-seed-admin.sh        # Genera hash e inserta admin
│   │   ├── 30-seed-categorias.sh   # Inserta categorias parametrizadas
│   │   ├── 40-reset-admin.sh       # Elimina y re-siembra admin
│   │   └── HashPassword/           # Codigo fuente del mini C# (referencia)
│   │       ├── HashPassword.csproj
│   │       └── Program.cs
│   └── seed/
│       ├── migrations.sql          # GENERADO: SQL idempotente de todas las migraciones
│       └── categorias.sql          # 10 categorias parametrizadas
│
├── api/                            # Imagen de la WebApi (.NET 10)
│   ├── Dockerfile                  # Solo copia publish/api (aspnet:10.0)
│   ├── .dockerignore
│   └── appsettings.Production.json # Cadena de conexion apuntando a "sqlserver"
│
└── web/                            # Imagen de Blazor Server (.NET 10)
    ├── Dockerfile                  # Solo copia publish/web (aspnet:10.0)
    ├── .dockerignore
    └── appsettings.Production.json # ApiBaseUrl apuntando a "api" + cadena a "sqlserver"
```

---

## 7. Como funciona internamente

1. **`sqlserver`** arranca SQL Server 2022 con la password `Admin123*` (o la del `.env`) y se expone en `localhost:14330` en el host (puerto interno del contenedor: `1433`).
2. **`db-init`** espera a que SQL Server este healthy, luego:
   - `10-apply-migrations.sh` ejecuta el archivo `migrations.sql` pre-generado (idempotente, usa `__EFMigrationsHistory` para no re-aplicar).
   - `20-seed-admin.sh` ejecuta la herramienta `HashPassword.dll` (mini programa .NET que reproduce la logica de `FinanKore.Dominio.Perfil.ObjetosValor.Credencial`) y luego inserta al usuario `admin@gmail.com` con el hash+Salt correctos.
   - `30-seed-categorias.sh` ejecuta `categorias.sql` con 10 categorias predeterminadas.
3. **`api`** arranca la WebApi (Minimal API + MediatR) en el puerto 8080 del contenedor, mapeado al **5157** del host.
4. **`web`** arranca Blazor Server (Radzen) en el puerto 8080 del contenedor, mapeado al **5175** del host. La Web hace llamadas HTTP a `http://api:8080` (resolucion por nombre de servicio en la red Docker).

Todos los servicios comparten la red `finankore-net` y se comunican por nombre de servicio, no por IP.

### Caracteristicas de portabilidad

- ✅ No requiere .NET SDK en la maquina destino.
- ✅ No requiere el codigo fuente de `src/` en la maquina destino.
- ✅ Las imagenes Docker pesan ~250 MB cada una (sin SDK).
- ✅ Las migraciones EF estan pre-generadas como un archivo SQL estatico.
- ✅ Los seeds (admin + categorias) son idempotentes: se pueden re-ejecutar sin duplicar datos.
- ✅ La base persiste entre reinicios (volumen Docker con nombre).
