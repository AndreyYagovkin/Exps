using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseJournalDeleteCommandHandler : HandlerDeleteBase<ExpenseJournalModel, ExpenseJournalDeleteCommand>
    {
        public ExpenseJournalDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseJournalModel FindModel(ExpenseJournalDeleteCommand command)
        {
            return _context.Find<ExpenseJournalModel>(a => a.Id == command.ExpenseJournalId);
        }
    }
}