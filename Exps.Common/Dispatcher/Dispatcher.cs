using Exps.Common.Commands;
using Exps.Common.Exceptions;
using Exps.Common.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exps.Common.Dispatcher
{
    /// <summary> Query/command resolver </summary>
    public class Dispatcher : IDispatcher
    {
        /// <summary> Collection of registered services </summary>
        private readonly IServiceCollection _services;

        /// <summary> Query/command resolver </summary>
        /// <param name="services"> Collection of registered services </param>
        public Dispatcher(IServiceCollection services)
        {
            _services = services;
        }

        public void Handle<TCommand>(TCommand command)
        {
            var handler = Resolve<IHandler<TCommand>>();

            if (handler == null)
                throw new Exception($"Handler for command {typeof(TCommand)} not found.");

            handler.Handle(command);
        }

        public IEnumerable<TView> HandleQuery<TEntity, TParams, TView>(TParams @params) 
            where TEntity : class
        {
            var query = Resolve<IQueryParametrizedView<TEntity, TParams, TView>>();
            
            if (query == null)
                throw new Exception($"Handler for query {typeof(TEntity)} not found.");

            return query.Execute(@params);
        }

        private TType Resolve<TType>() where TType : class
        {
            var provider = _services.BuildServiceProvider();
            
            var handlers = provider.GetServices<TType>();

            if (!handlers.Any())
                throw new HandlerNotFoundException(typeof(TType));

            // В случае, если какой-то обработчик задан более одного раза, выбираем обработчики, заданные наибольшее число раз.
            // Это позволит выявить обработчики, заданные напрямую. 
            var groupedHandlers = handlers.GroupBy(h => h.GetType().Name).Select(g => new { HandlerName = g.Key, Handler = g.First(), AssignCount = g.Count() }).Where(gh => gh.AssignCount > 1);
            if (groupedHandlers.Any())
            {
                int maxAssigned = groupedHandlers.Max(gh => gh.AssignCount);
                handlers = groupedHandlers.Where(gh => gh.AssignCount == maxAssigned).Select(gh => gh.Handler);
            }

            TType resolved = handlers.First();

            // для каждого найденого обработчика смотрим его прямых наследников
            // если наследник найден, то обработчик НЕ будет выполнен, а будет выполнен наследник
            // получаем переопределение поведения в Handler`ах
            foreach (var h in handlers)
            {
                var others = handlers.Where(t => t != h);
                TType inheriter = null;

                Type handlerType = h.GetType();
                foreach (var o in others)
                {
                    Type possibleInheriterType = o.GetType();

                    if (handlerType.IsAssignableFrom(possibleInheriterType))
                        inheriter = o;
                }

                if (inheriter != null)
                    continue;
                else
                    resolved = h;
            }

            return resolved;
        }
    }
}
