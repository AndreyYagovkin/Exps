using Exps.Common;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseTypeUpdateCommandHandler : HandlerUpdateBase<ExpenseTypeModel, ExpenseTypeUpdateCommand>
    {
        public ExpenseTypeUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseTypeModel FindModel(ExpenseTypeUpdateCommand command)
        {
            return _context.Find<ExpenseTypeModel>(a => a.ExpenseTypeId == command.ExpenseTypeId);
        }

        public override ExpenseTypeModel ApplyChanges(ExpenseTypeModel model, ExpenseTypeUpdateCommand command)
        {
            model.Name = command.ExpenseTypeName;
            return model;
        }
    }
}