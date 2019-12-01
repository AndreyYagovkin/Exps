using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseDeleteCommandHandler : HandlerDeleteBase<ExpenseGroupModel, ExpenseGroupDeleteCommand>
    {
        public ExpenseDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseGroupModel FindModel(ExpenseGroupDeleteCommand command)
        {
            return _context.Find<ExpenseGroupModel>(a => a.Id == command.ExpenseGroupId);
        }
    }
}