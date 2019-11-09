﻿using System.Linq;
using AutoMapper;
using Exps.Common.Context;
using Exps.Common.Queries;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core.Queries
{
    public class ExpenseTypeQuery : QueryBase<ExpenseModel, ExpenseTypeView>
    {
        public ExpenseTypeQuery(IDataContext context,
            IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}