using Exps.Common.Context;
using System.Collections.Generic;

namespace Exps.Common.Queries
{
    public abstract class QueryParametrized<TParams, TResult> : IQueryParametrized<TParams, TResult>
    {
        protected readonly IDataContext _context;

        protected QueryParametrized(IDataContext context)
        {
            _context = context;
        }

        public abstract IEnumerable<TResult> Execute(TParams @params);
    }
}