using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    #region video03
    public class MemberConfiguration:GymUserConfiguration<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.CreatedAt).HasColumnName("joinDate").HasColumnType("datetime").IsRequired();
            base.Configure(builder);
        }
    }
    #endregion


}
