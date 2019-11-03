using Exps.Common.Dispatcher;
using Exps.Core.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Exps.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController: ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public JournalController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        
        [HttpPost]
        [Route("Create")]
        public void Create(JournalCreateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Update")]
        public void Update(JournalUpdateCommand command)
        {
            _dispatcher.Handle(command);
        }

        [HttpPost]
        [Route("Delete")]
        public void Delete(JournalDeleteCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}