using System;

namespace Exps.Core.Commands
{
    public class ExpenseJournalCreateCommand
    {
        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseGroupId { get; set; }
        
        public string Comment { get; set; }
    }
}