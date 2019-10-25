using Microsoft.EntityFrameworkCore;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Shop.DataAccess
{
    public class ShopContext:DbContext
    {
        private readonly string connectionString;
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ShopContext()
        {
            connectionString = "Server=A-305-01;Database=ShopDb;Trusted_Connection=True;";
            Database.EnsureCreated();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
           //optionsBuilder.UseInMemoryDatabase("ShopDb");
        }
    }
}
