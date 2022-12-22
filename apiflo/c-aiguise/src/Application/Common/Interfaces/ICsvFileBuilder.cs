using c_aiguise.Application.TodoLists.Queries.ExportTodos;

namespace c_aiguise.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
