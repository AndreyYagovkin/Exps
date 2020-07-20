using AutoMapper;
using Exps.Common.Commands;
using Exps.Common.Context;
using Exps.Common.Dispatcher;
using Exps.Common.Queries;
using Exps.Core.Logic.Journal;
using Exps.Database.Context;
using Exps.WebClient.Areas.Journal.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Exps.Common.Services;

namespace Exps.WebClient
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ExpsContext>(opt =>
                opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
            );

            #region Types registration
            services.Scan(
               x =>
               {
                   var entryAssembly = Assembly.GetEntryAssembly();
                   var referencedAssemblies = entryAssembly.GetReferencedAssemblies().Select(Assembly.Load);
                   var assemblies = new List<Assembly> { entryAssembly }.Concat(referencedAssemblies);

                   x.FromAssemblies(assemblies)
                       .AddClasses(classes => classes.AssignableTo(typeof(IQueryParametrizedView<,,>)))
                       .AsImplementedInterfaces()
                       .WithScopedLifetime();

                   x.FromAssemblies(assemblies)
                       .AddClasses(classes => classes.AssignableTo(typeof(HandlerCreateBase<,>)))
                       .AsImplementedInterfaces()
                       .WithScopedLifetime();

                   x.FromAssemblies(assemblies)
                       .AddClasses(classes => classes.AssignableTo(typeof(HandlerDeleteBase<,>)))
                       .AsImplementedInterfaces()
                       .WithScopedLifetime();
               });

            services.AddAutoMapper(typeof(Core.CoreMapperProfile));
            services.AddTransient<IDataContext, ExpsContext>();
            services.AddSingleton<IDispatcher>(x => new Dispatcher(services));
            services.AddTransient<IJournalProvider, JournalProvider>();
            services.AddTransient<IJournalService, JournalService>();
            services.AddSingleton<IDateTimeService, DateTimeService>();

            #endregion Types registration
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areaRoute",
                    pattern: "{area:exists}/{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "api",
                    pattern: "{controller}/{id?}");
            });
        }
    }
}