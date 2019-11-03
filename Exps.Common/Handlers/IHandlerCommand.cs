namespace Exps.Common.Handlers
{
    public interface IHandlerCommand<TCommand>
    {
        void Execute(TCommand command);
    }
}
