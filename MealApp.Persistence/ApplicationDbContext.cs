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

        }

    }
}
