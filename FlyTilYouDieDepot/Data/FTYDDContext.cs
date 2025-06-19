using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyTilYouDieDepot.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace FlyTilYouDieDepot.Data
{
    public class FTYDDContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Plane> Planes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FlyTilYouDieDepot_Database;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers"); // Optional: Falls du eine bestimmte Tabellenname festlegen möchtest
                entity.HasKey(c => c.Email);
                entity.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);// Optional: Falls du eine andere Primärschlüsselkonfiguration benötigst
              //  entity.Property(e => e.FirstName).HasColumnName("FirstName");
              //  entity.Property(e => e.LastName).HasColumnName("LastName");

             

            });

            modelBuilder.Entity<Plane>(entity =>
            {
                entity.ToTable("Planes");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Price).HasColumnType("decimal(18,2)");
                entity.Property(p => p.Description).HasMaxLength(800);

            });

            modelBuilder.Entity <Order> (entity =>
            {
                entity.ToTable("Orders");
                entity.HasKey(o => o.Id); // Hier wird der Primärschlüssel als Id verwendet, anstatt CustomerId
                entity.HasOne(o => o.Customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId);
                entity.HasOne(o => o.Plane)
                    .WithMany() // "WithMany()" ist erforderlich, wenn "Plane" mehrere "Order" haben kann
                    .HasForeignKey(o => o.PlaneId); // Hier wird der Fremdschlüssel PlaneId verwendet
            });



        }

    }
}
