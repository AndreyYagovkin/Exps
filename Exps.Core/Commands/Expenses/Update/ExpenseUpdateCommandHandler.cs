using Exps.Commands;
using Exps.Common;
using Exps.Core.Models;

namespace Exps.Core.Commands
{
    public class ExpenseUpdateCommandHandler : HandlerUpdateBase<ExpenseModel, ExpenseUpdateCommand>
    {
        public ExpenseUpdateCommandHandler(IDataContext context) : base(context)
        {
        }

        public override ExpenseModel FindModel(ExpenseUpdateCommand command)
        {
            return _context.Find<ExpenseModel>(a => a.ExpenseId == command.ExpenseId);
        }

        public override ExpenseModel ApplyChanges(ExpenseModel model, ExpenseUpdateCommand command)
        {
            model.Name = command.ExpenseName;
            model.ExpenseTypeId = command.ExpenseTypeId;
            model.ParentId = command.ParentId;

            return model;
        }
    }
}