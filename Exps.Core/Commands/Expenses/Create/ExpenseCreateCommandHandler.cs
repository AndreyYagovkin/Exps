using Exps.Common.Context;
using Exps.Common.Handlers;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseCreateCommandHandler : HandlerCreateBase<ExpenseModel, ExpenseCreateCommand>
    {
        public ExpenseCreateCommandHandler(IDataContext context)
            : base(context)
        {
        }

        public override ExpenseModel CreateModel(ExpenseCreateCommand command)
        {
            return new ExpenseModel
            {
                Name = command.ExpenseName,
                ParentId = command.ParentId,
                ExpenseTypeId = command.ExpenseTypeId
            };
        }
    }
}
