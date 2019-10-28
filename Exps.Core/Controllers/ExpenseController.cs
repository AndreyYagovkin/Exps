using System.Collections.Generic;
using Exps.Commands;
using Exps.Common;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Controllers
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

        [HttpGet]
        [Route("one")]
        public void AddExpense()
        {
            var command = new CreateExpenseCommand
            {
                Name = "test"
            };
            _dispatcher.Handle(command);
        }
    }
}
