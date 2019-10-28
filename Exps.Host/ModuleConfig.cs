using Autofac;
using Exps.Common;
using Exps.Core;

namespace Exps.Host
{
    public class ModuleConfig : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonModule>();
            builder.RegisterModule<CoreModule>();
        }
    }
}