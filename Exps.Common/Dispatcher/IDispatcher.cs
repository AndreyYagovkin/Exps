using System.Linq;

namespace Exps.Common.Dispatcher
{
    public interface IDispatcher
    {
        void Handle<TCommand>(TCommand command);
        IQueryable<TModel> HandleQuery<TModel>();

    }
}
