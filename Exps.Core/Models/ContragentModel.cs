using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exps.Core.Models
{
    public class ContragentModel
    {
        public int ContragentId { get; set; }

        public string Name { get; set; }

        public List<JournalModel> JournalRows { get; set; }
    }
}
