using Exps.Common.Context;

namespace Exps.Common.Commands
{
    public abstract class HandlerCreateBase<TModel, TCommand> : IHandler<TCommand>
        where TModel : class
    {
        protected readonly IDataContext _context;

        public HandlerCreateBase(IDataContext context)
        {
            _context = context;
        }
        
        public virtual void Handle(TCommand command)
        {
            TModel model = CreateModel(command);

            _context.Add(model);
            _context.SaveChanges();
        }

        public abstract TModel CreateModel(TCommand command);
    }
}