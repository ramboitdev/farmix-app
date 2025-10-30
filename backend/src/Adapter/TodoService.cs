
using Application.Services;
using Core.Entities;
using Adapter.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class TodoService : ITodoService
    {
        private readonly AppDbContext _db;
        public TodoService(AppDbContext db) => _db = db;
        public async Task<Todo> CreateAsync(Todo todo)
        {
            _db.Todos.Add(todo);
            await _db.SaveChangesAsync();
            return todo;
        }
        public async Task<Todo?> GetAsync(int id) => await _db.Todos.FindAsync(id);
        public async Task<IEnumerable<Todo>> GetAllAsync() => await _db.Todos.AsNoTracking().ToListAsync();
    }
}
