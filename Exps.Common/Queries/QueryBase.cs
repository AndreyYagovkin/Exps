using System.Linq;
using Exps.Common.Context;
using AutoMapper;

namespace Exps.Common.Queries
{
    public abstract class QueryBase<TModel, TViewModel> : IQuery<TViewModel>
            where TModel : class
    {
        protected readonly IDataContext _context;
        private readonly IMapper _mapper;

        public QueryBase(IDataContext context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
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
            var mappedQuery = _mapper.ProjectTo<TViewModel>(query);
            return mappedQuery;
        }
    }
}