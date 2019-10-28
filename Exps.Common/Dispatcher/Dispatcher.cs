using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace Exps.Common
{
    public class Dispatcher : IDispatcher
    {
        private readonly IComponentContext _container;

        public Dispatcher(IComponentContext container)
        {
            _container = container;
        }

        public void Handle<TCommand>(TCommand command)
        {
            var handler = Resolve<IHandlerCommand<TCommand>>();

            if (handler == null)
                throw new Exception($"Handler for command {typeof(TCommand)} not found.");

            handler.Execute(command);
        }

        private TType Resolve<TType>(ILifetimeScope scope = null) where TType : class
        {
            IEnumerable<TType> handlers = (scope == null)
                ? _container.Resolve<IEnumerable<TType>>()
                : scope.Resolve<IEnumerable<TType>>();

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
