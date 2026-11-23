#region video02
using GymManagmentSystem.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagmentSystem.Contexts
{
    public class GymDbContext : DbContext
    {
        #region video 05
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        
        public DbSet<Member> Members { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }
        #region video 05
        public DbSet<MemberShip> MemberShips { get; set; }
        #endregion
    }
}
#endregion
