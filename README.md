
Farmix app (ASP.NET Core WebAPI + EF Core + Vue)

How to run backend:

1. Create a solution and add projects:
   dotnet new sln -n clean-skeleton
   dotnet sln add backend/src/Domain/Domain.csproj backend/src/Application/Application.csproj backend/src/Infrastructure/Infrastructure.csproj backend/src/WebAPI/WebAPI.csproj

2. From the repository root, add EF Core packages:
   dotnet add backend/src/Infrastructure package Npgsql.EntityFrameworkCore.PostgreSQL
   dotnet add backend/src/Infrastructure package Microsoft.EntityFrameworkCore.Design
   dotnet add backend/src/WebAPI package Npgsql.EntityFrameworkCore.PostgreSQL

3. If you use the CLI to manage migrations locally, install the tools:
   dotnet tool install --global dotnet-ef

4. Run with docker-compose (recommended):
   docker-compose up --build
   The WebAPI will be available at http://localhost:5195 and Postgres at localhost:5432
