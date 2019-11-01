using Autofac;

namespace Exps.Common
{
    public class CommonModule : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Dispatcher(c.Resolve<IComponentContext>()))
                .As<IDispatcher>()
                .InstancePerLifetimeScope();

            RegisterAll(builder);
        }
    }
}
