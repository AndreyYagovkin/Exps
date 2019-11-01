namespace Exps.Common
{
    public abstract class HandlerDeleteBase<TModel, TCommand> : IHandlerCommand<TCommand>
        where TModel : class
    {
        private readonly IDataContext _context;

        public HandlerDeleteBase(IDataContext context)
        {
            _context = context;
        }

        public virtual void Execute(TCommand command)
        {
            var model = FindModel(command);

            _context.Delete(model);
            _context.SaveChanges();
        }

        public abstract TModel FindModel(TCommand command);
    }
}