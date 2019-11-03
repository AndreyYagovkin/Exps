using Exps.Common.Context;
using Exps.Common.Handlers;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseDeleteCommandHandler : HandlerDeleteBase<ExpenseModel, ExpenseDeleteCommand>
    {
        public ExpenseDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseModel FindModel(ExpenseDeleteCommand command)
        {
            return _context.Find<ExpenseModel>(a => a.ExpenseId == command.ExpenseId);
        }
    }
}