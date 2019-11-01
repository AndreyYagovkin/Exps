using Exps.Commands;
using Exps.Common;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ExpenseController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        [Route("AddExpense")]
        public void AddExpense(ExpenseCreateCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
