using System.Linq;

namespace Exps.Common.Queries
{
    public interface IQueryParametrizedBasic<TModel, TParams, TViewModel>
        : IQueryParametrized<TParams, TViewModel>
        where TModel : class
        
    {
        IQueryable<TModel> GetQuery(TParams @params);
        IQueryable<TViewModel> MapModelQuery(IQueryable<TModel> query);
    }
}