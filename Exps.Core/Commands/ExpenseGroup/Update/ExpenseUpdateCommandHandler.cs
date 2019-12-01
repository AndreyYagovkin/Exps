using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseUpdateCommandHandler : HandlerUpdateBase<ExpenseGroupModel, ExpenseGroupUpdateCommand>
    {
        public ExpenseUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseGroupModel FindModel(ExpenseGroupUpdateCommand command)
        {
            return _context.Find<ExpenseGroupModel>(a => a.Id == command.ExpenseGroupId);
        }

        public override ExpenseGroupModel ApplyChanges(ExpenseGroupModel model, ExpenseGroupUpdateCommand command)
        {
            model.Name = command.ExpenseGroupName;
            model.ExpenseTypeId = command.ExpenseTypeId;
            model.ParentId = command.ParentId;

            return model;
        }
    }
}