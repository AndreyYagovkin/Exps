using AutoMapper;
using Exps.Common.Context;
using Exps.Common.Queries;
using System.Linq;

namespace Exps.Core.Logic.Journal
{
    public class GetJournalRecordsQuery : 
        QueryParametrizedView<Entities.Journal, GetJournalRecordsParams, GetJournalRecordsView>
    {
        public GetJournalRecordsQuery(IDataContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<Entities.Journal> GetQuery(GetJournalRecordsParams parameters)
        {
            var query = _context.Query<Entities.Journal>()
                .Where(x => x.Date == parameters.Date);

            return query;
        }
    }
}