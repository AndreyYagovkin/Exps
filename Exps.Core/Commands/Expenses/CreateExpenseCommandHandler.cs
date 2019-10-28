using Exps.Common;
using Exps.Core.Models;

namespace Exps.Commands
{
    public class CreateExpenseCommandHandler : IHandlerCommand<CreateExpenseCommand>
    {
        private readonly IDataContext _context;

        public CreateExpenseCommandHandler(IDataContext context) 
        {
            _context = context;
        }

        public void Execute(CreateExpenseCommand command)
        {
            var mod = new ExpenseModel
            {
                ExpenseId = 1,
                Name = command.Name
            };

            _context.Add(mod);

            _context.SaveChanges();
        }
    }
}
