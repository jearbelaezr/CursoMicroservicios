FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Contenedor.csproj", "Contenedor/"]
RUN dotnet restore "Contenedor/Contenedor.csproj"
COPY . .
WORKDIR "/src/Contenedor"
RUN dotnet build "Contenedor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contenedor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contenedor.dll"]
