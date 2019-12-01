using System.Linq;
using Exps.Common.Dispatcher;
using Exps.Core.Commands;
using Exps.Core.Views;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseGroupsController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ExpenseGroupsController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        
        public IQueryable<ExpenseGroupView> Get()
        {
            return _dispatcher.HandleQuery<ExpenseGroupView>();
        }

        [HttpPost]
        public void Create(ExpenseGroupCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        public void Update(ExpenseGroupUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        public void Delete(ExpenseGroupDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
