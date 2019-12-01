using System;

namespace Exps.Core.Models
{
    public class ExpenseJournalModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseGroupId { get; set; }
        public ExpenseGroupModel ExpenseGroup { get; set; }

        public string Comment { get; set; }

    }
}
