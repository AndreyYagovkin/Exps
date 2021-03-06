﻿using Exps.Common.Context;

namespace Exps.Common.Commands
{
    public abstract class HandlerDeleteBase<TModel, TCommand> : IHandler<TCommand>
        where TModel : class
    {
        protected readonly IDataContext _context;

        public HandlerDeleteBase(IDataContext context)
        {
            _context = context;
        }

        public virtual void Handle(TCommand command)
        {
            var model = FindModel(command);

            _context.Remove(model);
            _context.SaveChanges();
        }

        public abstract TModel FindModel(TCommand command);
    }
}