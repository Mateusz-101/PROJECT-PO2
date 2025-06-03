using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Models;
using System.Collections.Generic;
using OSPManagementSystem.Data.Seed;

namespace OSPManagementSystem.Data
{
    public class OSPContext : DbContext
    {
        public OSPContext(DbContextOptions<OSPContext> options) : base(options) { }

        public DbSet<Firefighter> Firefighters { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<RescueAction> RescueActions { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<ActionFirefighter> ActionFirefighters { get; set; }
        public DbSet<ActionEquipment> ActionEquipments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DataSeeder.Seed(modelBuilder);

            modelBuilder.Entity<ActionFirefighter>()
                .HasKey(af => new { af.ActionId, af.FirefighterId });

            modelBuilder.Entity<ActionEquipment>()
                .HasKey(ae => new { ae.ActionId, ae.EquipmentId });

            modelBuilder.Entity<Firefighter>()
                .HasMany(f => f.Trainings)
                .WithMany(t => t.Firefighters);

            modelBuilder.Entity<RescueAction>()
                .HasMany(r => r.Firefighters)
                .WithMany(f => f.RescueActions);

            modelBuilder.Entity<RescueAction>()
                .HasMany(r => r.Equipment)
                .WithMany(e => e.RescueActions);
        }
    }
}