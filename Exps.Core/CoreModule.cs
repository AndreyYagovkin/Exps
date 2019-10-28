using Autofac;
using Exps.Common;

namespace Exps.Core
{
    public class CoreModule : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterAll(builder);
        }
    }
}
