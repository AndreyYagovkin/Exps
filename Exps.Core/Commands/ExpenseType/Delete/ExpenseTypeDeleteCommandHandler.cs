using System.Linq;
using Exps.Common;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseTypeDeleteCommandHandler : HandlerDeleteBase<ExpenseTypeModel, ExpenseTypeUpdateCommand>
    {
        public ExpenseTypeDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public void Execute(ExpenseTypeUpdateCommand command)
        {
            var deletingEntities = _context.Query<ExpenseTypeModel>()
                .Where(x => command.ExpenseIds.Contains(x.ExpenseTypeId));

            _context.Delete(deletingEntities);
            _context.SaveChanges();
        }
    }
}