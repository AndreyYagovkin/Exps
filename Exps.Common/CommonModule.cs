using Autofac;
using Exps.Common.Dispatcher;

namespace Exps.Common
{
    public class CommonModule : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Dispatcher.Dispatcher(c.Resolve<IComponentContext>()))
                .As<IDispatcher>()
                .InstancePerLifetimeScope();

            RegisterAll(builder);
        }
    }
}
