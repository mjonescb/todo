using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo
{
    public class RealLifeTodoFetcher : IFetchTodoItems
    {
        public Task<IEnumerable<TodoModel>> GetTodoAsync()
        {
            return Task.FromResult(new[]
            {
                new TodoModel { Id = Guid.NewGuid(), Text = "Buy milk" },
                new TodoModel { Id = Guid.NewGuid(), Text = "Pay tax" },
                new TodoModel { Id = Guid.NewGuid(), Text = "Brush dog" }
            }.AsEnumerable());
        }
    }
}