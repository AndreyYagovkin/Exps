using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exps.Core.Logic.Journal;
using Exps.WebClient.Areas.Journal.Models;

namespace Exps.WebClient.Areas.Journal.Services
{
    public interface IJournalService
    {
        IEnumerable<RecordListModel> GetRecords(DateTime date);
        void AddRecord(AddRecordModel record);
        void DeleteRecord(int journalRecordId);
    }
}
