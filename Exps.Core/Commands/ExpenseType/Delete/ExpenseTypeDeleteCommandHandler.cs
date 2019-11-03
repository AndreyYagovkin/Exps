using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseTypeDeleteCommandHandler : HandlerDeleteBase<ExpenseTypeModel, ExpenseTypeDeleteCommand>
    {
        public ExpenseTypeDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseTypeModel FindModel(ExpenseTypeDeleteCommand command)
        {
            return _context.Find<ExpenseTypeModel>(a => a.ExpenseTypeId == command.ExpenseTypeId);
        }
    }
}