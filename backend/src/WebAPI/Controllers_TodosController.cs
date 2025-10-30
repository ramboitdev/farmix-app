
using Application.Services;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    private readonly ITodoService _service;
    public TodosController(ITodoService service) => _service = service;

    [HttpGet]
    public async Task<IEnumerable<Todo>> GetAll() => await _service.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Todo>> Get(int id)
    {
        var t = await _service.GetAsync(id);
        if (t == null) return NotFound();
        return Ok(t);
    }

    [HttpPost]
    public async Task<ActionResult<Todo>> Create(Todo todo)
    {
        var created = await _service.CreateAsync(todo);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }
}
