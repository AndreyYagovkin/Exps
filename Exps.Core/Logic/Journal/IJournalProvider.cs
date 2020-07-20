using System;
using System.Collections.Generic;
using System.Text;

namespace Exps.Core.Logic.Journal
{
    public interface IJournalProvider
    {
        IEnumerable<GetJournalRecordsView> GetJournalRecords(GetJournalRecordsParams @params);
        void AddJournalRecord(AddJournalRecordCommand command);
        void DeleteJournalRecord(DeleteJournalRecordCommand command);
    }
}
