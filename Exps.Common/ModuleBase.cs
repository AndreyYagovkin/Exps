using Autofac;
using Exps.Common.AutoMapper;
using Exps.Common.Commands;
using Exps.Common.Queries;

namespace Exps.Common
{
    public abstract class ModuleBase : Module
    {
        protected void RegisterAll(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .AsClosedTypesOf(typeof(IHandlerCommand<>));
            
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .AsClosedTypesOf(typeof (IQuery<>));
            
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .AsClosedTypesOf(typeof (IQueryParametrized<,>));
            
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .AsClosedTypesOf(typeof(IQuerySingle<>));
            
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .AsClosedTypesOf(typeof (IQuerySingleParametrized<,>));
            
            builder.RegisterModule(new AutoMapperModule(GetType().Assembly));
        }
    }
}
