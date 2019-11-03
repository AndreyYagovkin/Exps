namespace Exps.Core.Commands
{
    public class ExpenseUpdateCommand
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
