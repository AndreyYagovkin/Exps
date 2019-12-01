using System.Collections.Generic;

namespace Exps.Core.Models
{
    public class ExpenseTypeModel : ClassifierBaseModel
    {
        public List<ExpenseGroupModel> ExpenseGroups { get; set; }
    }
}
