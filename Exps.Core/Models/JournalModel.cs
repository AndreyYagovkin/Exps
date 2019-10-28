using System;
using System.ComponentModel.DataAnnotations;

namespace Exps.Core.Models
{
    public class JournalModel
    {
        public int JournalId { get; set; }

        public DateTime Date { get; set; }

        public decimal Sum { get; set; }

        public int? ExpenseId { get; set; }
        public ExpenseModel Expense { get; set; }

        public int? ContragentId { get; set; }
        public ContragentModel Contragent { get; set; }

        public int? ParticipantId { get; set; }
        public ParticipantModel Participant { get; set; }


    }
}
