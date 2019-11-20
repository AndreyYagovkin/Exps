using AutoMapper;
using Exps.Common.Context;
using Exps.Common.Queries;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core.Queries
{
    public class JournalQuery : QueryBase<JournalModel, JournalView>
    {
        public JournalQuery(IDataContext context,
            IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}