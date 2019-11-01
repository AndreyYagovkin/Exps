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
                .HasKey(x => x.ExpenseTypeId)
                .HasName("PK_ExpenseTypeId");

            modelBuilder.Entity<ExpenseTypeModel>()
                .HasMany(x => x.Expenses)
                .WithOne(x => x.ExpenseType);

            //Expenses
            modelBuilder.Entity<ExpenseModel>()
                .ToTable("Expense")
                .HasKey(x => x.ExpenseId)
                .HasName("PK_ExpenseId");

            modelBuilder.Entity<ExpenseModel>()
                .HasMany(x => x.JournalRows)
                .WithOne(x => x.Expense);

            //Journal
            modelBuilder.Entity<JournalModel>()
                .ToTable("Journal")
                .HasKey(x => x.JournalId)
                .HasName("PK_JournalId");

        }
    }
}
