using System.Linq;
using Exps.Common.Context;

namespace Exps.Common.Queries
{
    public abstract class QueryParametrized<TParams, TResult> : IQueryParametrized<TParams, TResult>
    {
        readonly protected IDataContext _context;

        protected QueryParametrized(IDataContext dataContext)
        {
            _context = dataContext;
        }

        public abstract IQueryable<TResult> Execute(TParams @params);
    }
}