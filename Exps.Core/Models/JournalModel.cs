using System;

namespace Exps.Core.Models
{
    public class JournalModel
    {
        public int JournalId { get; set; }

        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseId { get; set; }
        public ExpenseModel Expense { get; set; }

        public string Comment { get; set; }

    }
}
