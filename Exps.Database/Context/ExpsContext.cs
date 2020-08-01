using Exps.Common.Context;
using Exps.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;

namespace Exps.Database.Context
{
    public class ExpsContextFactory : IDesignTimeDbContextFactory<ExpsContext>
    {
        public ExpsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ExpsContext>();
            return new ExpsContext(optionsBuilder.Options);
        }
    }

    //[DebuggerStepThrough]
    public class ExpsContext : DataContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=./exps.db;");

        public ExpsContext(DbContextOptions<ExpsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            IEntityConfiguration config = Activator.CreateInstance(typeof(CoreEntityConfiguration)) as IEntityConfiguration;

            DisableCascadeDeletes(modelBuilder);

            config.AddConfiguration(modelBuilder);
        }

        private void DisableCascadeDeletes(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

    }
}