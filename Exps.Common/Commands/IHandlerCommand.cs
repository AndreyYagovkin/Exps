namespace Exps.Common.Commands
{
    public interface IHandlerCommand<TCommand>
    {
        void Execute(TCommand command);
    }
}
