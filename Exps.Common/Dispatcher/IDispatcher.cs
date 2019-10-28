namespace Exps.Common
{
    public interface IDispatcher
    {
        void Handle<TCommand>(TCommand command);
    }
}
