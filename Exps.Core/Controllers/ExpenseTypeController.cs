using Exps.Common.Dispatcher;
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
        public void Create(ExpenseTypeCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Update")]
        public void Update(ExpenseTypeUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Delete")]
        public void Delete(ExpenseTypeDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
