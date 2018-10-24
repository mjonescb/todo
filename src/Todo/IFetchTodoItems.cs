using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todo
{
    public interface IFetchTodoItems
    {
        Task<IEnumerable<TodoModel>> GetTodoAsync();
    }
}