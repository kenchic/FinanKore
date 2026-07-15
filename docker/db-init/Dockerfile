FROM mcr.microsoft.com/dotnet/aspnet:10.0

ENV DEBIAN_FRONTEND=noninteractive
ENV PATH="$PATH:/opt/mssql-tools18/bin"

# Instalar mssql-tools18 (sqlcmd) para conectarse a SQL Server
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        curl apt-transport-https gnupg ca-certificates \
    && curl -fsSL https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor -o /usr/share/keyrings/microsoft-prod.gpg \
    && curl -fsSL https://packages.microsoft.com/config/debian/12/prod.list \
        | tee /etc/apt/sources.list.d/mssql-release.list \
    && apt-get update \
    && ACCEPT_EULA=Y apt-get install -y --no-install-recommends mssql-tools18 \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /workspace

# Herramienta HashPassword pre-compilada (generada por publish-local.ps1)
COPY ./publish/hash-password/ /tools/HashPassword/

# Scripts bash y archivos de seed
COPY ./db-init/scripts/ /workspace/db-init/scripts/
COPY ./db-init/seed/    /workspace/db-init/seed/

# Hacer ejecutables los scripts bash
RUN chmod +x /workspace/db-init/scripts/*.sh

# Punto de entrada: ejecuta migraciones, luego siembra admin y categorias
ENTRYPOINT ["/bin/bash", "-c", "set -e; /workspace/db-init/scripts/10-apply-migrations.sh && /workspace/db-init/scripts/20-seed-admin.sh && /workspace/db-init/scripts/30-seed-categorias.sh && echo '==== db-init COMPLETADO ===='"]
