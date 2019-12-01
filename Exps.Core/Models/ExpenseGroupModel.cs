using System.Collections.Generic;

namespace Exps.Core.Models
{
    public class ExpenseGroupModel : ClassifierBaseModel
    {
        public int? ParentId { get; set; }
        public int ExpenseTypeId { get; set; }
        public ExpenseTypeModel ExpenseType { get; set; }
        public List<ExpenseJournalModel> ExpenseJournalRows { get; set; }
    }
}
