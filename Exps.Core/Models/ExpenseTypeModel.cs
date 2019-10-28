using System.Collections.Generic;

namespace Exps.Core.Models
{
    public class ExpenseTypeModel
    {
        public int ExpenseTypeId { get; set; }
        public string Name { get; set; }

        public List<ExpenseModel> Expenses { get; set; }
    }
}
