using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using Xunit;
using Application.Services;
using Domain.Entities;

namespace StoreApp.Test
{
    public class ProductServiceTests
    {
        StoreDbContext _context;
        public ProductServiceTests()
        {
            DbContextOptionsBuilder<StoreDbContext> builder = new DbContextOptionsBuilder<StoreDbContext>().UseInMemoryDatabase("StoreDb");
            _context = new StoreDbContext(builder.Options);
        }
        

        [Fact]
        public async void ServiceShouldCreateProduct()
        {
            var productService = new ProductService(_context);
            var testProduct = new Product() { Name = "Test", CategoryId = 1, Description = "Test", Price = 200 };
            await productService.Add(testProduct);
            Assert.Contains(testProduct, _context.Products);
        }
        [Fact]
        public async void ServiceShouldUpdateProduct()
        {
            var productService = new ProductService(_context);
            var testProduct = new Product() { Name = "Test", CategoryId = 1, Description = "Test", Price = 200 };
            await productService.Add(testProduct);
            testProduct.Name = "John";

            var result = await productService.Update(testProduct);

            Assert.Equal(testProduct, result);
        }
        [Fact]
        public async void ServiceShouldDeleteProduct()
        {
            var productService = new ProductService(_context);
            var testProduct = new Product() { Name = "Test", CategoryId = 1, Description = "Test", Price = 200 };
            await productService.Add(testProduct);

            await productService.Delete(testProduct.Id);

            Assert.DoesNotContain(testProduct, _context.Products);
        }
    }
}
