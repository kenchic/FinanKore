#!/bin/bash
set -e

echo "[reset] Eliminando admin y sus preferencias existentes ..."
/opt/mssql-tools18/bin/sqlcmd \
    -S sqlserver \
    -U sa \
    -P "$SA_PASSWORD" \
    -C \
    -No \
    -d FinanKore \
    -Q "
DELETE FROM Configuracion.Preferencias WHERE UsuarioId IN (SELECT Id FROM Perfil.Usuarios WHERE Correo = 'admin@gmail.com');
DELETE FROM Perfil.Usuarios WHERE Correo = 'admin@gmail.com';
PRINT '--> Admin y preferencias eliminados.';
"

echo "[reset] Re-sembrando admin ..."
/workspace/db-init/scripts/20-seed-admin.sh
