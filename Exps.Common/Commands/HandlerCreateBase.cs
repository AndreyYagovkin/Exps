namespace Exps.Common
{
    public abstract class HandlerCreateBase<TModel, TCommand> : IHandlerCommand<TCommand>
        where TModel : class
    {
        private readonly IDataContext _context;

        public HandlerCreateBase(IDataContext context)
        {
            _context = context;
        }

        public virtual void Execute(TCommand command)
        {
            TModel model = CreateModel(command);

            _context.Add(model);
            _context.SaveChanges();
        }

        public abstract TModel CreateModel(TCommand command);
    }
}