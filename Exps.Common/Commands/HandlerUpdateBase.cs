using Exps.Common.Context;

namespace Exps.Common.Commands
{
    public abstract class HandlerUpdateBase<TModel, TCommand> : IHandler<TCommand>
        where TModel : class
    {
        protected readonly IDataContext _context;

        public HandlerUpdateBase(IDataContext context)
        {
            _context = context;
        }

        public virtual void Handle(TCommand command)
        {
            TModel found = FindModel(command);
            TModel modified = ApplyChanges(found, command);

            _context.Update(modified);
            _context.SaveChanges();
        }

        public abstract TModel FindModel(TCommand command);
        public abstract TModel ApplyChanges(TModel model, TCommand command);
    }
}