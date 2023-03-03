using Ecomerce.Application.TodoLists.Queries.ExportTodos;

namespace Ecomerce.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
