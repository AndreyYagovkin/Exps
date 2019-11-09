using System.Linq;
using Exps.Common.Dispatcher;
using Exps.Core.Commands;
using Exps.Core.Views;
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
        
        public IQueryable<ExpenseView> Get()
        {
            return _dispatcher.HandleQuery<ExpenseView>();
        }

        [HttpPost]
        [Route("Create")]
        public void Create(ExpenseCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Update")]
        public void Update(ExpenseUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Delete")]
        public void Delete(ExpenseDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
