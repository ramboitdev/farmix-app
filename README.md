
Clean Architecture minimal skeleton (ASP.NET Core WebAPI + EF Core + Angular)

How to run backend (locally):
1. Create a solution and add projects:
   dotnet new sln -n clean-skeleton
   dotnet sln add backend/src/Domain/Domain.csproj backend/src/Application/Application.csproj backend/src/Infrastructure/Infrastructure.csproj backend/src/WebAPI/WebAPI.csproj
2. From the repository root, add EF Core packages:
   dotnet add backend/src/Infrastructure package Npgsql.EntityFrameworkCore.PostgreSQL
   dotnet add backend/src/Infrastructure package Microsoft.EntityFrameworkCore.Design
   dotnet add backend/src/WebAPI package Npgsql.EntityFrameworkCore.PostgreSQL
3. (Optional) If you use the CLI to manage migrations locally, install the tools:
   dotnet tool install --global dotnet-ef
4. Run with docker-compose (recommended):
   docker-compose up --build
   The WebAPI will be available at http://localhost:5195 and Postgres at localhost:5432

Notes:
- Program.cs is configured to apply EF Core migrations automatically at startup (db.Database.Migrate()).
- The Migrations folder contains an InitialCreate migration and a model snapshot so the database schema can be created automatically when the container starts.
