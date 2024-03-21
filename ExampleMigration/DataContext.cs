using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ExampleMigration
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExampleMigration;Trusted_Connection=True;");
        }
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
