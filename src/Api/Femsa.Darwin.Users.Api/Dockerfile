FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Api/Femsa.Darwin.Users.Api/Femsa.Darwin.Users.Api.csproj", "src/Api/Femsa.Darwin.Users.Api/"]
RUN dotnet restore "src/Api/Femsa.Darwin.Users.Api/Femsa.Darwin.Users.Api.csproj"
COPY . .
WORKDIR "/src/src/Api/Femsa.Darwin.Users.Api"
RUN dotnet build "Femsa.Darwin.Users.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Femsa.Darwin.Users.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Femsa.Darwin.Users.Api.dll"]
