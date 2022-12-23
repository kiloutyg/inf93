using c_aiguise.Application.Common.Mappings;
using c_aiguise.Domain.Entities;

namespace c_aiguise.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
