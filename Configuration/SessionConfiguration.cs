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
                x.HasCheckConstraint("CK_startEndTimeConstraint", "startTime < endTime");
            });
            #region video 05
            builder.HasOne(s => s.trainer).WithMany(t => t.Sessions).HasForeignKey(s => s.TrainerId).OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
    #endregion
}




