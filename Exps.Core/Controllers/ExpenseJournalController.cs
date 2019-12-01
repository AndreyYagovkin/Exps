using System.Linq;
using Exps.Common.Dispatcher;
using Exps.Core.Commands;
using Exps.Core.Views;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseJournalController: ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public ExpenseJournalController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        
        public IQueryable<JournalView> Get()
        {
            return _dispatcher.HandleQuery<JournalView>();
        }
        
        [HttpPost]
        [Route("Create")]
        public void Create(ExpenseJournalCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Update")]
        public void Update(ExpenseJournalUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Delete")]
        public void Delete(ExpenseJournalDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}