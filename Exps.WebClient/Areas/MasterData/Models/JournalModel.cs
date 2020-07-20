using System.Collections.Generic;

namespace Exps.WebClient.Areas.Journal.Models
{
    public class JournalModel
    {
        public AddRecordModel AddRecord { get; set; }
        public IEnumerable<RecordListModel> Records { get; set; }
    }
}
