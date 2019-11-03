namespace Exps.Common.Dispatcher
{
    public interface IDispatcher
    {
        void Handle<TCommand>(TCommand command);
        //void HandleCreate<TCommand>(TCommand command);

    }
}
