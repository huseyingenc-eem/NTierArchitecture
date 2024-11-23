using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Context
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HUSEYIN;Initial Catalog=ETicaret;Integrated Security=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DB tablolarımız oluşturulurken onlara müdahale edebiliriz.
            // OrderDetail tablosunun Id alanını iptal edeceğiz.
            modelBuilder.Entity<OrderDetail>().Ignore(x=>x.ID);

            // bunun yerine Product ve OrderId alanlarınız Composite Key yapacağız. x=>x.ID burda bunu direk olarak kullanamıyorsun 2 parametre verilecekse new lenip  süslü parentez içersiinde verilir.
            modelBuilder.Entity<OrderDetail>().HasKey(o=>new {
                o.ProductID,
                o.OrderID
            });
        }
    }
}
