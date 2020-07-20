using System.Collections.Generic;
using AutoMapper;
using Exps.Common.Context;
using System.Linq;

namespace Exps.Common.Queries
{
    public class QueryParametrizedView<TEntity, TParams, TModel> 
        : QueryParametrized<TParams, TModel>, 
        IQueryParametrizedView<TEntity, TParams, TModel> where TEntity : class
    {
        private readonly IMapper _mapper;
        
        public QueryParametrizedView(IDataContext context, 
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public override IEnumerable<TModel> Execute(TParams @params)
        {
            var modelQuery = GetQuery(@params);
            var resultQuery = MapModelQuery(modelQuery);
            return resultQuery;
        }

        public virtual IQueryable<TEntity> GetQuery(TParams parameters)
        {
            var query = _context.Query<TEntity>();
            return query;
        }

        public virtual IEnumerable<TModel> MapModelQuery(IQueryable<TEntity> query)
        {
            var mappedQuery = _mapper.ProjectTo<TModel>(query);
            return mappedQuery;
        }
    }
}