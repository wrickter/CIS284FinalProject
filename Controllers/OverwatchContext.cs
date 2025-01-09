using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class OverwatchContext : DbContext
    {
        public OverwatchContext(DbContextOptions<OverwatchContext> options)
            : base(options)
        {
        }

        public DbSet<TankPageItem> Tanks { get; set; }
        public DbSet<DamagePageItem> Damage { get; set; }
        public DbSet<SupportPageItem> Support { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TankPageItem>()
       .HasKey(t => t.HeroName);
            modelBuilder.Entity<DamagePageItem>()
        .HasKey(d => d.HeroName);
            modelBuilder.Entity<SupportPageItem>()
          .HasKey(s => s.HeroName);
            
            modelBuilder.Entity<TankPageItem>().ToTable("Tanks");
            modelBuilder.Entity<DamagePageItem>().ToTable("Damage");
            modelBuilder.Entity<SupportPageItem>().ToTable("Support");
        }
    }
}
