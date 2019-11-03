using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Exps.Common.Context;

namespace Exps.Common.Queries
{
    public class QueryParametrizedBase<TModel, TParams, TViewModel> 
        : QueryParametrized<TParams, TViewModel>, IQueryParametrizedBasic<TModel, TParams, TViewModel> 
        where TModel : class
    {
        private readonly IConfigurationProvider _mapperConfig;
        
        public QueryParametrizedBase(IDataContext context, 
            IConfigurationProvider mapperConfig) : base(context)
        {
            _mapperConfig = mapperConfig;
        }

        public override IQueryable<TViewModel> Execute(TParams @params)
        {
            var modelQuery = GetQuery(@params);
            var resultQuery = MapModelQuery(modelQuery);
            return resultQuery;
        }

        public virtual IQueryable<TModel> GetQuery(TParams parameters)
        {
            var query = _context.Query<TModel>();
            return query;
        }

        public virtual IQueryable<TViewModel> MapModelQuery(IQueryable<TModel> query)
        {
            var mappedQuery = query.ProjectTo<TViewModel>(_mapperConfig);
            return mappedQuery;
        }
    }
}