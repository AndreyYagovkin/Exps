using Exps.Common.Context;
using Exps.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Exps.Core.Context
{
    public class CoreEntityConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            //ExpenseTypes
            modelBuilder.Entity<ExpenseTypeModel>()
                .ToTable("ExpenseType")
                .HasKey(x => x.Id)
                .HasName("PK_ExpenseTypeId");

            modelBuilder.Entity<ExpenseTypeModel>()
                .HasMany(x => x.ExpenseGroups)
                .WithOne(x => x.ExpenseType);

            //ExpenseGroups
            modelBuilder.Entity<ExpenseGroupModel>()
                .ToTable("ExpenseGroup")
                .HasKey(x => x.Id)
                .HasName("PK_ExpenseGroupId");

            modelBuilder.Entity<ExpenseGroupModel>()
                .HasMany(x => x.ExpenseJournalRows)
                .WithOne(x => x.ExpenseGroup);

            //ExpenseJournal
            modelBuilder.Entity<ExpenseJournalModel>()
                .ToTable("ExpenseJournal")
                .HasKey(x => x.Id)
                .HasName("PK_ExpenseJournalId");

        }
    }
}
