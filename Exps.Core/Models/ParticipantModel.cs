using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exps.Core.Models
{
    public class ParticipantModel
    {
        public int ParticipantId { get; set; }

        public string Name { get; set; }

        public List<JournalModel> JournalRows { get; set; }
    }
}
