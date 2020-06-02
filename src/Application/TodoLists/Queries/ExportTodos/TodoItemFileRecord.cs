using AzureTest.Application.Common.Mappings;
using AzureTest.Domain.Entities;

namespace AzureTest.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
