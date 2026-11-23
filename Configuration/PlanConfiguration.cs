using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    #region video03
    public class PlanConfiguration :  IEntityTypeConfiguration<Plan>
    {
        public  void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("getdate()");
            builder.ToTable(x =>
            {
               
                x.HasCheckConstraint("CK_DurationDaysConstraint", "DurationDays between 1 and 365");
            });


        }   
    
    }
    #endregion
}
