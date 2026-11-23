using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    #region video03
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("getdate()");
            builder.ToTable(x =>
            {
                x.HasCheckConstraint("CK_capacityconstraint", "capacity between 1 and 25");
                x.HasCheckConstraint("CK_startEndDateConstraint", "startDate < endDate");                                                                                                                                                        
            });

        }
    }
    #endregion
}




