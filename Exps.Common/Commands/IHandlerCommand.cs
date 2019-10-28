namespace Exps.Common
{
    public interface IHandlerCommand<TCommand>
    {
        void Execute(TCommand command);
    }
}
