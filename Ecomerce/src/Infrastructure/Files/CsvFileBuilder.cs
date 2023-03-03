using System.Globalization;
using Ecomerce.Application.Common.Interfaces;
using Ecomerce.Application.TodoLists.Queries.ExportTodos;
using Ecomerce.Infrastructure.Files.Maps;
using CsvHelper;

namespace Ecomerce.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
