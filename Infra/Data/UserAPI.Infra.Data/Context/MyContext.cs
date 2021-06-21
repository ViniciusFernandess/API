using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserAPI.Domain.Entities;
using UserAPI.Infra.Data.Mapping;

namespace UserAPI.Infra.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }

    }
}
