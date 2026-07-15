#!/bin/bash
set -e

echo "[migrations] Esperando a SQL Server en sqlserver:1433 ..."

INTENTOS=0
MAX_INTENTOS=60
until /opt/mssql-tools18/bin/sqlcmd \
        -S sqlserver \
        -U sa \
        -P "$SA_PASSWORD" \
        -C \
        -No \
        -Q "SELECT 1" > /dev/null 2>&1; do
    INTENTOS=$((INTENTOS + 1))
    if [ $INTENTOS -ge $MAX_INTENTOS ]; then
        echo "[migrations] ERROR: SQL Server no respondio despues de $MAX_INTENTOS intentos."
        exit 1
    fi
    echo "[migrations] Aun no disponible (intento $INTENTOS/$MAX_INTENTOS), esperando 2s..."
    sleep 2
done

echo "[migrations] SQL Server disponible."

echo "[migrations] Creando base de datos FinanKore si no existe ..."
/opt/mssql-tools18/bin/sqlcmd \
    -S sqlserver \
    -U sa \
    -P "$SA_PASSWORD" \
    -C \
    -No \
    -Q "IF DB_ID('FinanKore') IS NULL CREATE DATABASE FinanKore; PRINT '--> Base FinanKore lista.';"

echo "[migrations] Ejecutando migrations.sql (idempotente) en FinanKore ..."
/opt/mssql-tools18/bin/sqlcmd \
    -S sqlserver \
    -U sa \
    -P "$SA_PASSWORD" \
    -C \
    -No \
    -b \
    -d FinanKore \
    -i /workspace/db-init/seed/migrations.sql

echo "[migrations] Migraciones aplicadas correctamente."
