using System.Collections.Generic;

namespace Exps.Common.Queries
{
    public interface IQueryParametrized<in TParams, out TModel>
    {
        IEnumerable<TModel> Execute(TParams @params);
    } 
 }