using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class JournalCreateCommandHandler : HandlerCreateBase<JournalModel, JournalCreateCommand>
    {
        public JournalCreateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override JournalModel CreateModel(JournalCreateCommand command)
        {
            return new JournalModel
            {
                Date = command.Date,
                Sum = command.Sum,
                ExpenseId = command.ExpenseId,
                Comment = command.Comment
            };
        }
    }
}