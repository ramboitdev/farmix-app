
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetAllAsync();
        Task<Todo?> GetAsync(int id);
        Task<Todo> CreateAsync(Todo todo);
    }
}
