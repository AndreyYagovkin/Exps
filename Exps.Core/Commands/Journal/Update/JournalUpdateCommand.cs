using System;

namespace Exps.Core.Commands
{
    public class JournalUpdateCommand
    {
        public int JournalId { get; set; }
        
        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseId { get; set; }
        
        public string Comment { get; set; }    }
}