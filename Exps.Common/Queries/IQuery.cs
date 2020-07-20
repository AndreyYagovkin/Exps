using System.Collections.Generic;

namespace Exps.Common.Queries
{
    public interface IQuery<out T>
    {
        IEnumerable<T> Execute();
    }
}