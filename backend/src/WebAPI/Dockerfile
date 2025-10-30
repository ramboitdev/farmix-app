
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "src/WebAPI/WebAPI.csproj"
RUN dotnet publish "src/WebAPI/WebAPI.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:5195
EXPOSE 5195
ENTRYPOINT ["dotnet", "WebAPI.dll"]
