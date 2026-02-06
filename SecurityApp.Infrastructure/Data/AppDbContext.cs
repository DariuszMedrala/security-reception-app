using Microsoft.EntityFrameworkCore;
using SecurityApp.Core.Entities;
using SecurityApp.Core.Entities.Enums;

namespace SecurityApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Avization> Avizations { get; set; }
        public DbSet<Guest> Guests { get; set; } 
        public DbSet<Note> Notes { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<PhonebookEntry> Phonebook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.Building)
                .WithMany(b => b.Users)
                .HasForeignKey(u => u.BuildingId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Guest>()
                .HasOne(g => g.Building)
                .WithMany(b => b.Guests)
                .HasForeignKey(g => g.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Avization>()
                .HasOne(a => a.Building)
                .WithMany(b => b.Avizations)
                .HasForeignKey(a => a.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Note>()
                .HasOne(n => n.Building)
                .WithMany(b => b.Notes)
                .HasForeignKey(n => n.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ParkingSpot>()
                .HasOne(p => p.Building)
                .WithMany(b => b.ParkingSpots)
                .HasForeignKey(p => p.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Building>().HasData(
                new Building { Id = 1, Name = "Budynek E", Code = "E" },
                new Building { Id = 2, Name = "Budynek F", Code = "F" },
                new Building { Id = 3, Name = "Budynek H", Code = "H" }
            );

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 1,
                    UserName = "admin",
                    PasswordHash = "admin123",
                    Role = Role.Admin,
                    BuildingId = null
                }
            );

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 2,
                    UserName = "recepcjaE",
                    PasswordHash = "user123E",
                    Role = Role.Reception,
                    BuildingId = 1
                }
            );

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 3,
                    UserName = "recepcjaF",
                    PasswordHash = "user123F",
                    Role = Role.Reception,
                    BuildingId = 2
                }
            );
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 4,
                    UserName = "recepcjaH",
                    PasswordHash = "user123H",
                    Role = Role.Reception,
                    BuildingId = 3
                }
            );
        }
    }
}