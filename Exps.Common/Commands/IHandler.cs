namespace Exps.Common.Commands
{
    public interface IHandler<in TCommand>
    {
        void Handle(TCommand command);
    }
}