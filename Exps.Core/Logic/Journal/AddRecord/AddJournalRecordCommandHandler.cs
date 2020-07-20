using Exps.Common.Commands;
using Exps.Common.Context;

namespace Exps.Core.Logic.Journal
{
    public class AddJournalRecordCommandHandler : HandlerCreateBase<Entities.Journal, AddJournalRecordCommand>
    {
        public AddJournalRecordCommandHandler(IDataContext context) : base(context)
        {
        }

        public override Entities.Journal CreateModel(AddJournalRecordCommand command)
        {
            return new Entities.Journal
            {
                Date = command.Date,
                Sum = command.Sum
            };
        }
    }
}