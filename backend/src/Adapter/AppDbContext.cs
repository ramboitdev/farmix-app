
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adapter.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
