using Microsoft.EntityFrameworkCore;

namespace Exps.Common.Context
{
    public interface IEntityConfiguration
    {
        void AddConfiguration(ModelBuilder modelBuilder);
    }
}
