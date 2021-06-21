using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using UserAPI.Infra.Data.Context;

namespace UserAPI.Infra.Data.ContextFactory
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>

    {
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LKHOEMI\SQLEXPRESS;Integrated Security=True;Database=dbAPI;");

            return new MyContext(optionsBuilder.Options);
        }
    }
}
