using Autofac;
using Exps.Common;
using Exps.Common.Context;
using Exps.Core;
using Microsoft.EntityFrameworkCore;

namespace Exps.Host
{
    public class ModuleConfig : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExpsContext>().As<IDataContext>().As<DbContext>()
                .InstancePerLifetimeScope();

            builder.RegisterModule<CommonModule>();
            builder.RegisterModule<CoreModule>();
        }
    }
}