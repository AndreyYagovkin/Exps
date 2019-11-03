using Exps.Common.Context;
using Exps.Common.Handlers;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class JournalDeleteCommandHandler : HandlerDeleteBase<JournalModel, JournalDeleteCommand>
    {
        public JournalDeleteCommandHandler(IDataContext context) : base(context)
        {
        }

        public override JournalModel FindModel(JournalDeleteCommand command)
        {
            return _context.Find<JournalModel>(a => a.JournalId == command.JournalId);
        }
    }
}