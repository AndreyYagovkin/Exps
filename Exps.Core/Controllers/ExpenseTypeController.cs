using Exps.Common;
using Exps.Core.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ExpenseTypeController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        [Route("Create")]
        public void ExpenseTypeCreate(ExpenseTypeCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Update")]
        public void ExpenseTypeUpdate(ExpenseTypeUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Delete")]
        public void AddExpense(ExpenseTypeUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
