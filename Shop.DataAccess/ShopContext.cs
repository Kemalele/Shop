using Microsoft.EntityFrameworkCore;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Shop.DataAccess
{
    public class ShopContext:DbContext
    {
        private readonly string connectionString;
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ShopContext()
        {
            //connectionString = "Server=A-305-01;Database=ShopDb;Trusted_Connection=True;";
            connectionString = "Server=127.0.0.1;Port=5432;Database=testt;Integrated Security=true; ";
            Database.EnsureCreated();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseNpgsql(connectionString);
           //optionsBuilder.UseInMemoryDatabase("ShopDb");
        }
    }
}
