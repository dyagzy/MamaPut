using System;
using System.Collections.Generic;
using System.Text;
using MealApp.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MealApp2.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCook> DishCooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Cook>()
                .Property(c => c.RowVersion).IsRowVersion();
            modelBuilder.Entity<Cook>()
                .Property(c => c.CookName).IsRequired();
            modelBuilder.Entity<Cook>()
                .HasMany(c => c.Customers)
                .WithOne(e => e.Cook);
            modelBuilder.Entity<Cook>()
                .HasMany(c => c.Dishes)
                .WithOne(d => d.Cook);

            modelBuilder.Entity<Dish>()
                .HasOne(d => d.Cook)
                .WithMany(c => c.Dishes);


            modelBuilder.Entity<DishCook>()
                .HasKey(dc => new { dc.DishId, dc.CookId });

            modelBuilder.Entity<Customer>()
                .HasOne(e => e.Cook)
                .WithMany(c => c.Customers);
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Dishes)
                .WithOne(d => d.Customer);

        }
        

    }
}
