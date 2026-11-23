using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    #region video03
    public class GymUserConfiguration<Tuser> : IEntityTypeConfiguration<Tuser> where Tuser : GymUser
    {
        public void Configure(EntityTypeBuilder<Tuser> builder)
        {
            builder.Property(u => u.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(u => u.Email).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(u => u.Phone).HasColumnType("nvarchar(11)").IsRequired();
            builder.ComplexProperty(u => u.Address, address =>
            {
                address.IsRequired ();
                address.Property(a => a.Street).HasColumnType("nvarchar(100)").IsRequired();
                address.Property(a => a.City).HasColumnType("nvarchar(50)").IsRequired();
            });
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.Phone).IsUnique();

            builder.ToTable(x => {
                x.HasCheckConstraint("CK_EmailConstraint", "[Email] LIKE '%@%.%'");
           x.HasCheckConstraint("CK_PhoneConstraint", "len(phone) = 11  and (phone like '010%' or phone like '011%' or phone like '012%' or phone like '015%') ");

            });
            

        }
    }
    #endregion
}
