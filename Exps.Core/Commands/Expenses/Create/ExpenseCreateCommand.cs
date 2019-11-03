namespace Exps.Core.Commands
{
    public class ExpenseCreateCommand
    {
        public string ExpenseName { get; set; }
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
