using System.Globalization;
using c_aiguise.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace c_aiguise.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
