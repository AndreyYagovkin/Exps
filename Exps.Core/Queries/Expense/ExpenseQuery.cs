using AutoMapper;
using Exps.Common.Context;
using Exps.Common.Queries;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core.Queries
{
    public class ExpenseQuery : QueryBase<ExpenseModel, ExpenseView>
    {
        public ExpenseQuery(IDataContext context,
            IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}