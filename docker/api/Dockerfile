FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

# Copiar el output de dotnet publish (generado por publish-local.ps1)
COPY ./publish/api/ ./

# Sobrescribir appsettings con la version de produccion apuntando al servicio "sqlserver"
COPY ./api/appsettings.Production.json ./appsettings.Production.json

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production
ENV DOTNET_RUNNING_IN_CONTAINER=true

EXPOSE 8080

ENTRYPOINT ["dotnet", "FinanKore.WebApi.dll"]
