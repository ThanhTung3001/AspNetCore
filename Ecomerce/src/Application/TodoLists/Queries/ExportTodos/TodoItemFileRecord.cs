using Ecomerce.Application.Common.Mappings;
using Ecomerce.Domain.Entities;

namespace Ecomerce.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
