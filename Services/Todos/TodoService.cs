using App.Models.Todos;
using App.Models;

namespace App.Services.Todos
{
  public class TodoService : List<Todo>
  {
    private readonly AppDbContext _context;

    public TodoService(AppDbContext context)
    {
      _context = context;
    }
  }
}