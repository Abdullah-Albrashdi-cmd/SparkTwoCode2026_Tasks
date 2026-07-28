using E_CommerceDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceDatabase
{
    public class AppDbContext : DbContext // oop inheritance
    {
        //1- register models
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }




        //2- connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }




    }
}
