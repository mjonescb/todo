using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Todo
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private readonly IFetchTodoItems _fetcher;

        public TodoController(IFetchTodoItems fetcher)
        {
            _fetcher = fetcher;
        }

        [HttpGet, Route("")]
        public async Task<IActionResult> Index()
        {
            return Json(await _fetcher.GetTodoAsync());
        }
    }
}