# Use the ASP.NET Core runtime base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Copy the published output of your ASP.NET Core application to the container
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ApiAquiTemBarbearia.csproj", "./"]
RUN dotnet restore "ApiAquiTemBarbearia.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "ApiAquiTemBarbearia.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "ApiAquiTemBarbearia.csproj" -c Release -o /app/publish

# Final stage/image for the container
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiAquiTemBarbearia.dll"]
