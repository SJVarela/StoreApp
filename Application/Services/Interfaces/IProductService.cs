using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProduct(int id);
        Task<IEnumerable<Category>> GetCategories();
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);

    }
}
