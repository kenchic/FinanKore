#!/bin/bash
set -e

ADMIN_CORREO="admin@gmail.com"
ADMIN_NOMBRES="Admin"
ADMIN_APELLIDOS="Principal"
ADMIN_ID="00000000-0000-0000-0000-000000000001"
PREF_ID="00000000-0000-0000-0000-000000000002"
ADMIN_PASSWORD="Admin123*"

echo "[seed-admin] Generando hash para el password del administrador ..."

RESULTADO=$(dotnet /tools/HashPassword/HashPassword.dll "$ADMIN_PASSWORD")
HASH=$(echo "$RESULTADO" | cut -d: -f1)
SALT=$(echo "$RESULTADO" | cut -d: -f2)

if [ -z "$HASH" ] || [ -z "$SALT" ]; then
    echo "[seed-admin] ERROR: no se pudo generar el hash."
    exit 1
fi

echo "[seed-admin] Hash generado correctamente."

echo "[seed-admin] Insertando usuario admin y sus preferencias ..."

/opt/mssql-tools18/bin/sqlcmd \
    -S sqlserver \
    -U sa \
    -P "$SA_PASSWORD" \
    -C \
    -No \
    -d FinanKore \
    -Q "
IF NOT EXISTS (SELECT 1 FROM Perfil.Usuarios WHERE Correo = '$ADMIN_CORREO')
BEGIN
    INSERT INTO Perfil.Usuarios (Id, Correo, Nombres, Apellidos, PasswordHash, PasswordSalt, ImagenUrl, FechaRegistro, Activo)
    VALUES ('$ADMIN_ID', '$ADMIN_CORREO', '$ADMIN_NOMBRES', '$ADMIN_APELLIDOS', '$HASH', '$SALT', NULL, GETUTCDATE(), 1);
    PRINT '--> Usuario admin insertado.';
END
ELSE
    PRINT '--> El usuario admin ya existe, no se duplica.';

IF NOT EXISTS (SELECT 1 FROM Configuracion.Preferencias WHERE UsuarioId = '$ADMIN_ID')
BEGIN
    INSERT INTO Configuracion.Preferencias (Id, UsuarioId, Tema)
    VALUES ('$PREF_ID', '$ADMIN_ID', 'Claro');
    PRINT '--> Preferencias del admin insertadas (Tema=Claro).';
END
ELSE
    PRINT '--> Las preferencias del admin ya existen.';
"

echo "[seed-admin] Listo. Credenciales: $ADMIN_CORREO / $ADMIN_PASSWORD"
