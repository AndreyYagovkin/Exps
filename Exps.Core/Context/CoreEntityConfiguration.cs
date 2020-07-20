using Exps.Common.Context;
using Exps.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exps.Core.Context
{
    public class CoreEntityConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            //Journal
            modelBuilder.Entity<Journal>()
                .ToTable("Journal")
                .HasKey(x => x.Id)
                .HasName("PK_JournalId");

            modelBuilder.Entity<Journal>()
                .Property(x => x.Sum)
                .HasColumnType("real");
        }
    }
}
