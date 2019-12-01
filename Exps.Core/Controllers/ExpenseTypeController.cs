using System.Linq;
using Exps.Common.Dispatcher;
using Exps.Core.Commands;
using Exps.Core.Views;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypesController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;
        
        public ExpenseTypesController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public IQueryable<ExpenseTypeView> Get()
        {
           return _dispatcher.HandleQuery<ExpenseTypeView>();
        }

        [HttpPost]
        public void Create(ExpenseTypeCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPut]
        public void Update(ExpenseTypeUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpDelete]
        public void Delete(ExpenseTypeDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
