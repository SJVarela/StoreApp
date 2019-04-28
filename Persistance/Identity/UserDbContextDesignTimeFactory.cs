using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Identity
{
    public class UserDbContextDesignTimeFactory : IDesignTimeDbContextFactory<UserDbContext>
    {
        public UserDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<UserDbContext>();
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Integrated Security=true;Initial Catalog=AppStore;");
            return new UserDbContext(options.Options);
        }
    }
}
