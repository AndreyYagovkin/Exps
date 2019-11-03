using System.Linq;

namespace Exps.Common.Queries
{
    public interface IQueryParametrized<in TParams, out T>
    {
        IQueryable<T> Execute(TParams @params);
    } 
 }