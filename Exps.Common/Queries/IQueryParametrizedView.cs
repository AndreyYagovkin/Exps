using System.Collections.Generic;
using System.Linq;

namespace Exps.Common.Queries
{
    public interface IQueryParametrizedView<TEntity, in TParams, out TModel> :
        IQueryParametrized<TParams, TModel>
        
    {
        IQueryable<TEntity> GetQuery(TParams @params);
        IEnumerable<TModel> MapModelQuery(IQueryable<TEntity> query);
    }
}