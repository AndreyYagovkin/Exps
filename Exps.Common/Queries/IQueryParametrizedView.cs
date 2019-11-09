using System.Linq;

namespace Exps.Common.Queries
{
    public interface IQueryParametrizedView<TModel, TParams, TViewModel> : IQueryParametrized<TParams, TViewModel>
        where TModel : class
        
    {
        IQueryable<TModel> GetQuery(TParams @params);
        IQueryable<TViewModel> MapModelQuery(IQueryable<TModel> query);
    }
}