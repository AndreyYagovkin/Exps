namespace Exps.Core.Commands
{
    public class ExpenseGroupUpdateCommand
    {
        public int ExpenseGroupId { get; set; }
        public string ExpenseGroupName { get; set; }
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
