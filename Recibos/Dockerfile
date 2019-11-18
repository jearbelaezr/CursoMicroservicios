FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Recibos/Recibos.csproj", "Recibos/"]
RUN dotnet restore "Recibos/Recibos.csproj"
COPY . .
WORKDIR "/src/Recibos"
RUN dotnet build "Recibos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Recibos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Recibos.dll"]