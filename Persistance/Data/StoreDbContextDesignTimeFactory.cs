using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Data
{
    class StoreDbContextDesignTimeFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>();
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Integrated Security=true;Initial Catalog=AppStore;");
            return new StoreDbContext(options.Options);
        }
    }
}
