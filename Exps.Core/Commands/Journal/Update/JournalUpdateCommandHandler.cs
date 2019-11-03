using Exps.Common.Context;
using Exps.Common.Handlers;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class JournalUpdateCommandHandler: HandlerUpdateBase<JournalModel, JournalUpdateCommand>
    {
        public JournalUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override JournalModel FindModel(JournalUpdateCommand command)
        {
            return _context.Find<JournalModel>(a => a.JournalId == command.JournalId);
        }

        public override JournalModel ApplyChanges(JournalModel model, JournalUpdateCommand command)
        {
            model.Date = command.Date;
            model.Sum = command.Sum;
            model.ExpenseId = command.ExpenseId;
            model.Comment = command.Comment;

            return model;
        }
    }
    
}