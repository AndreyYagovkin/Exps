using System.Linq;

namespace Exps.Common.Queries
{
    public interface IQuery<out T>
    {
        IQueryable<T> Execute();
    }
}