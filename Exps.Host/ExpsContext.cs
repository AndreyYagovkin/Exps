﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using Exps.Common;
using Exps.Common.Context;
using Exps.Core.Context;

namespace Exps.Host
{
    [DebuggerStepThrough]
    public class ExpsContext : DataContext
    {
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