using Exps.Common.Dispatcher;
using System.Collections.Generic;

namespace Exps.Core.Logic.Journal
{
    /// <summary> Provider to journal commands </summary>
    public class JournalProvider : IJournalProvider
    {
        /// <summary> Query/command resolver </summary>
        private readonly IDispatcher _dispatcher;

        /// <summary> Provider to journal commands </summary>
        /// <param name="dispatcher"> Query/command resolver </param>
        public JournalProvider(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        /// <summary> Get all records by filter </summary>
        /// <param name="params"> Query filter parameters </param>
        /// <returns> Journal records in memory </returns>
        public IEnumerable<GetJournalRecordsView> GetJournalRecords(GetJournalRecordsParams @params)
        {
            var records = _dispatcher.HandleQuery<Entities.Journal, GetJournalRecordsParams, GetJournalRecordsView>(@params);
            return records;
        }

        /// <summary> Add new record to journal</summary>
        /// <param name="command"> Command parameters </param>
        public void AddJournalRecord(AddJournalRecordCommand command)
        {
            _dispatcher.Handle(command);
        }

        /// <summary> Fully delete a record from journal</summary>
        /// <param name="command"> Command parameters </param>
        public void DeleteJournalRecord(DeleteJournalRecordCommand command)
        {
            _dispatcher.Handle(command);
        }
    }
}
