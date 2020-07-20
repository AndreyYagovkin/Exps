using System;

namespace Exps.Core.Commands
{
    public class ExpenseJournalUpdateCommand
    {
        public int ExpenseJournalId { get; set; }
        
        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseGroupId { get; set; }
        
        public string Comment { get; set; }    }
}