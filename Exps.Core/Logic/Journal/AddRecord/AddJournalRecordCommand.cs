using System;

namespace Exps.Core.Logic.Journal
{
    public class AddJournalRecordCommand
    {
        public DateTime Date { get; set; }

        public decimal Sum { get; set; }
    }
}