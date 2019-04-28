using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new OrderItemConfiguration())
                .ApplyConfiguration(new OrderConfiguration())
                .ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
