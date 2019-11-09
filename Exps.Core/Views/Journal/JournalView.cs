using System;

namespace Exps.Core.Views
{
    public class JournalView
    {
        public int JournalId { get; set; }

        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseId { get; set; }

        public string Comment { get; set; }
    }
}
