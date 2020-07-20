using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseJournalUpdateCommandHandler: HandlerUpdateBase<ExpenseJournalModel, ExpenseJournalUpdateCommand>
    {
        public ExpenseJournalUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseJournalModel FindModel(ExpenseJournalUpdateCommand command)
        {
            return _context.Find<ExpenseJournalModel>(a => a.Id == command.ExpenseJournalId);
        }

        public override ExpenseJournalModel ApplyChanges(ExpenseJournalModel model, ExpenseJournalUpdateCommand command)
        {
            model.Date = command.Date;
            model.Sum = command.Sum;
            model.ExpenseGroupId = command.ExpenseGroupId;
            model.Comment = command.Comment;

            return model;
        }
    }
    
}