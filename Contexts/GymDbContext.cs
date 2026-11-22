#region video02
using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Contexts
{
    public class GymDbContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<GymUser> GymUsers { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }

    }
}
#endregion
