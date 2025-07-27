using Diploma.Models.Add;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Diploma.Models
{
    public class MyDbContext : DbContext
    {
        //public DbSet<User> Users { get; set; } = null!;
        public DbSet<AbonentAdd> Abonents { get; set; }
        public DbSet<ControllersAdd> ControllersAdds { get; set; }
        public DbSet<ContractAdd> Contracts { get; set; }
        public DbSet<MeterAdd> Meters { get; set; }
        public DbSet<PointAdd> Points { get; set; }
        public DbSet<UnitAdd> Units { get; set; }
        public DbSet<ReadingAdd> ReadingAdds { get; set; }
        public DbSet<ConsumptionAdd> ConsumptionAdds { get; set; }
        public DbSet<TransformerAdd> Transformers { get; set; }
        public DbSet<MountMeterAdd> MountMeters { get; set; }
        public DbSet<MountTrasformer> MountTrasformers { get; set; }
        public DbSet<PointsBoundAdd> PointsBounds { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeterAdd>()
             .HasOne(u => u.MountMeter)
             .WithOne(p => p.MeterAdd)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransformerAdd>()
              .HasOne(u => u.MountTrasformers)
              .WithMany(p => p.TransformerAdds)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReadingAdd>()
              .HasOne(u => u.MountMeterAdd)
              .WithMany(p => p.ReadingAdd)
              .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
