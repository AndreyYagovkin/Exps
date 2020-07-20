using Exps.Core.Logic.Journal;
using Exps.WebClient.Areas.Journal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exps.WebClient.Areas.Journal.Services
{
    public class JournalService : IJournalService
    {
        private readonly IJournalProvider _journalProvider;

        public JournalService(IJournalProvider journalProvider)
        {
            _journalProvider = journalProvider;
        }

        public IEnumerable<RecordListModel> GetRecords(DateTime date)
        {
            var @params = new GetJournalRecordsParams {Date = date};

            var journalRecords = _journalProvider.GetJournalRecords(@params).ToList();

            var records = journalRecords.Select(x => new RecordListModel
            {
                Id = x.Id,
                Date = x.Date,
                Sum = x.Sum
            });

            return records;
        }

        public void AddRecord(AddRecordModel record)
        {
            var command = new AddJournalRecordCommand {Date = record.Date, Sum = record.Sum};
            _journalProvider.AddJournalRecord(command);
        }

        public void DeleteRecord(int journalRecordId)
        {
            var command = new DeleteJournalRecordCommand {Id = journalRecordId};
            _journalProvider.DeleteJournalRecord(command);
        }

    }
}
