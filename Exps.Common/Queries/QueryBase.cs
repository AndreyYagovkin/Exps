using System.Linq;
using AutoMapper.QueryableExtensions;
using Exps.Common.Context;
using AutoMapper;

namespace Exps.Common.Queries
{
    public class QueryBase
    {
        public abstract class QueryBasic<TModel, TViewModel> : IQuery<TViewModel>
            where TModel : class
        {
            protected readonly IDataContext _context;
            private readonly IConfigurationProvider _mapperConfig;

            public QueryBasic(IDataContext context,
                IConfigurationProvider mapperConfig)
            {
                _context = context;
                _mapperConfig = mapperConfig;
            }

            public virtual IQueryable<TViewModel> Execute()
            {
                var modelQuery = GetQuery();
                var resultQuery = MapModelQuery(modelQuery);
                return resultQuery;
            }

            public virtual IQueryable<TModel> GetQuery()
            {
                var q = _context.Query<TModel>();
                return q;
            }

            public virtual IQueryable<TViewModel> MapModelQuery(IQueryable<TModel> query)
            {
                var mappedQuery = query.ProjectTo<TViewModel>(_mapperConfig);

                return mappedQuery;
            }
        }
    }
}