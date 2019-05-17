using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        StoreDbContext _context;
        public ProductService(StoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var storeDbContext = _context.Products.Include(p => p.Category);
            return await storeDbContext.ToListAsync();
        }

        public async Task Update(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
