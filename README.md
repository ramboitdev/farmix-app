
Clean Architecture minimal skeleton (ASP.NET Core WebAPI + EF Core + Angular)

How to run backend (locally):
1. Create a solution and add projects:
   dotnet new sln -n clean-skeleton
   dotnet sln add src/Domain/Domain.csproj src/Application/Application.csproj src/Infrastructure/Infrastructure.csproj src/WebAPI/WebAPI.csproj
2. From src/WebAPI run migrations and start:
   dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
   dotnet ef migrations add InitialCreate -p ../Infrastructure -s .
   dotnet ef database update -p ../Infrastructure -s .
   dotnet run --project src/WebAPI

Notes:
- This is a simplified scaffold intended as a starting point. Adjust namespaces, add real solution file, and set up EF migrations and DI registrations as needed.
- Frontend is a minimal placeholder. Run `npm install` and `ng serve` after creating a proper Angular project (or use Angular CLI to scaffold).
