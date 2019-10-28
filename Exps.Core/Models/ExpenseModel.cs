using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exps.Core.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public int ExpenseTypeId { get; set; }
        public ExpenseTypeModel ExpenseType { get; set; }

        public List<JournalModel> JournalRows { get; set; }
    }
}
