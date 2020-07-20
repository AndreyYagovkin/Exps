using System.Collections.Generic;
using System.Linq;
using Exps.Common.Context;
using AutoMapper;

namespace Exps.Common.Queries
{
    public abstract class QueryBase<TEntity, TModel> : IQuery<TModel> where TEntity : class
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        protected QueryBase(IDataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<TModel> Execute()
        {
            var modelQuery = GetQuery();
            var resultQuery = MapModelQuery(modelQuery);
            return resultQuery;
        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            var q = _context.Query<TEntity>();
            return q;
        }

        public virtual IQueryable<TModel> MapModelQuery(IQueryable<TEntity> query)
        {
            var mappedQuery = _mapper.ProjectTo<TModel>(query);
            return mappedQuery;
        }
    }
}