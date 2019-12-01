namespace Exps.Core.Commands
{
    public class ExpenseGroupCreateCommand
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
