using System.Linq;
using Exps.Common.Context;
using Exps.Common.Queries;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core.Queries
{
    public class GetListOfExpenseGroupsQuery : IQuery<ExpenseGroupView>
    {
        private readonly IDataContext _context;

        public GetListOfExpenseGroupsQuery(IDataContext context)
        {
            _context = context;
        }

        public IQueryable<ExpenseGroupView> Execute()
        {
            var query = _context.Query<ExpenseGroupModel>();

            var result = query.Select(x => new ExpenseGroupView
            {
                ExpenseGroupId = x.Id,
                ExpenseGroupName = x.Name,
                ExpenseGroupLevel = 1,
                ExpenseGroupParentName = "123qwe",
                ExpenseGroupTypeName = "123"
            });

            return result;
        }
    }
}