using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Data
{
    public class StoreDbContextSeed
    {
        private StoreDbContext _context;
        public StoreDbContextSeed(StoreDbContext context)
        {
            _context = context;
            SeedStore();
        }

        private void SeedStore()
        {
            if (!_context.Products.Any())
            {
                SeedCategories();
                SeedProducts();

                _context.SaveChanges();
            }
        }

        private void SeedCategories()
        {
            _context.Categories.Add(new Category() { Name = "Sports" });
            _context.Categories.Add(new Category() { Name = "Instruments" });
            _context.Categories.Add(new Category() { Name = "Books" });
            _context.Categories.Add(new Category() { Name = "Furniture" });

        }

        private void SeedProducts()
        {
            _context.Products.Add(new Product() { Name = "Ball", Price = 200, Description = "A ball", CategoryId = 1 });
            _context.Products.Add(new Product() { Name = "Guitar", Price = 300, Description = "A Guitar", CategoryId = 2 });
            _context.Products.Add(new Product() { Name = "Learn Norsk", Price = 100, Description = "A Book to learn about norway", CategoryId = 3 });
            _context.Products.Add(new Product() { Name = "Chair", Price = 150, Description = "A wooden chair", CategoryId = 4 });
            _context.Products.Add(new Product() { Name = "Wooden Ball", Price = 50, Description = "A wooden ball", CategoryId = 1 });
        }
    }
}
