#!/bin/bash
set -e

echo "[seed-cat] Insertando categorias predeterminadas ..."
/opt/mssql-tools18/bin/sqlcmd \
    -S sqlserver \
    -U sa \
    -P "$SA_PASSWORD" \
    -C \
    -No \
    -d FinanKore \
    -i /workspace/db-init/seed/categorias.sql

echo "[seed-cat] Listo."
