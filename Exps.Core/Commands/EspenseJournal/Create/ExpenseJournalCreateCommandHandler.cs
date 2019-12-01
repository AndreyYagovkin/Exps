using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseJournalCreateCommandHandler : HandlerCreateBase<ExpenseJournalModel, ExpenseJournalCreateCommand>
    {
        public ExpenseJournalCreateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseJournalModel CreateModel(ExpenseJournalCreateCommand command)
        {
            return new ExpenseJournalModel
            {
                Date = command.Date,
                Sum = command.Sum,
                ExpenseGroupId = command.ExpenseGroupId,
                Comment = command.Comment
            };
        }
    }
}