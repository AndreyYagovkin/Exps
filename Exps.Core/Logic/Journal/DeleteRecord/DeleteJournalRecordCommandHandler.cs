using Exps.Common.Commands;
using Exps.Common.Context;
using System.Linq;

namespace Exps.Core.Logic.Journal
{
    public class DeleteJournalRecordCommandHandler : HandlerDeleteBase<Entities.Journal, DeleteJournalRecordCommand>
    {
        public DeleteJournalRecordCommandHandler(IDataContext context) : base(context)
        {
        }

        public override Entities.Journal FindModel(DeleteJournalRecordCommand command)
        {
            var query = _context.Query<Entities.Journal>()
                .SingleOrDefault(x => x.Id == command.Id);

            return query;
        }
    }
}
