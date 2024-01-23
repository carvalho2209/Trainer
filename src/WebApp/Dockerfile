FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /root

# Common
COPY ["src/Shared/Shared.csproj", "src/Shared/"]
COPY ["src/Domain/Domain.csproj", "src/Domain/"]
COPY ["src/Application/Application.csproj", "src/Application/"]
COPY ["src/Authorization/Authorization.csproj", "src/Authorization/"]
COPY ["src/Infrastructure/Infrastructure.csproj", "src/Infrastructure/"]
COPY ["src/Persistence/Persistence.csproj", "src/Persistence/"]
COPY ["src/EndPoints/EndPoints.csproj", "src/EndPoints/"]

# Modules - Users
COPY ["src/Modules.Users.Domain/Modules.Users.Domain.csproj", "src/Modules.Users.Domain/"]
COPY ["src/Modules.Users.Application/Modules.Users.Application.csproj", "src/Modules.Users.Application/"]
COPY ["src/Modules.Users.Endpoints/Modules.Users.Endpoints.csproj", "src/Modules.Users.Endpoints/"]
COPY ["src/Modules.Users.Infrastructure/Modules.Users.Infrastructure.csproj", "src/Modules.Users.Infrastructure/"]
COPY ["src/Modules.Users.Persistence/Modules.Users.Persistence.csproj", "src/Modules.Users.Persistence/"]


# Executable
COPY ["src/WebApp/WebApp.csproj", "src/WebApp/"]

RUN dotnet restore "src/WebApp/WebApp.csproj"

COPY . .

WORKDIR "/root/src/WebApp"
RUN dotnet build "WebApp.csproj" --configuration Release --output /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" --configuration Release --output /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.dll"]