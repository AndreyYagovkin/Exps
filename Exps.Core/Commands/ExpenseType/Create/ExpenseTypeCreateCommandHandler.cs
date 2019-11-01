using Exps.Common;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseTypeUpdateCommandHandler : HandlerCreateBase<ExpenseTypeModel, ExpenseTypeCreateCommand>
    {
        public ExpenseTypeUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseTypeModel CreateModel(ExpenseTypeCreateCommand command)
        {
            return new ExpenseTypeModel()
            {
                Name = command.ExpenseName
            };
        }
    }
}