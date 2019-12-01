using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseGroupCreateCommandHandler : HandlerCreateBase<ExpenseGroupModel, ExpenseGroupCreateCommand>
    {
        public ExpenseGroupCreateCommandHandler(IDataContext context)
            : base(context)
        {
        }

        public override ExpenseGroupModel CreateModel(ExpenseGroupCreateCommand command)
        {
            return new ExpenseGroupModel
            {
                Name = command.Name,
                ParentId = command.ParentId,
                ExpenseTypeId = command.ExpenseTypeId
            };
        }
    }
}
