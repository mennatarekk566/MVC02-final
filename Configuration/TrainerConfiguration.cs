using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    #region video03
    public class TrainerConfiguration:GymUserConfiguration<Trainer>,IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(t => t.CreatedAt).HasColumnName("createdDate").HasColumnType("datetime").IsRequired();
            base.Configure(builder);
        }
    }

    
    #endregion
}
