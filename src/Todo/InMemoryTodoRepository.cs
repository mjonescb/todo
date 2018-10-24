using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo
{
    public class InMemoryTodoRepository : IFetchTodoItems
    {
        public Task<IEnumerable<TodoModel>> GetTodoAsync()
        {
            return Task.FromResult(new[]
            {
                new TodoModel { Id = Guid.NewGuid(), Text = "Test Item 1" },
                new TodoModel { Id = Guid.NewGuid(), Text = "Test Item 2" },
                new TodoModel { Id = Guid.NewGuid(), Text = "Test Item 3" }
            }.AsEnumerable());
        }
    }
}