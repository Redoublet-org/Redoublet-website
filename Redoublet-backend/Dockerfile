#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Redoublet-backend/Redoublet-backend.csproj", "Redoublet-backend/"]
RUN dotnet restore "Redoublet-backend/Redoublet-backend.csproj"
COPY . .
WORKDIR "/src/Redoublet-backend"
RUN dotnet build "Redoublet-backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Redoublet-backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Redoublet-backend.dll"]