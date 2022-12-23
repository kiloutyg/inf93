using System.Globalization;
using c_aiguise.Application.Common.Interfaces;
using c_aiguise.Application.TodoLists.Queries.ExportTodos;
using c_aiguise.Infrastructure.Files.Maps;
using CsvHelper;

namespace c_aiguise.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
