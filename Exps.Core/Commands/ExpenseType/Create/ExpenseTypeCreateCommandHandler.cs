using Exps.Common.Context;
using Exps.Common.Commands;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseTypeCreateCommandHandler : HandlerCreateBase<ExpenseTypeModel, ExpenseTypeCreateCommand>
    {
        public ExpenseTypeCreateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseTypeModel CreateModel(ExpenseTypeCreateCommand command)
        {
            return new ExpenseTypeModel()
            {
                Name = command.ExpenseTypeName
            };
        }
    }
}