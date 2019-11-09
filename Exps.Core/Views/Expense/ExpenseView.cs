namespace Exps.Core.Views
{
    public class ExpenseView
    {
        public int ExpenseId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
