using c_aiguise.Application.Common.Mappings;
using c_aiguise.Domain.Entities;

namespace c_aiguise.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
