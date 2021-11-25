using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataBase.Models;
using DataBase.Model_Config;

namespace DataBase.Context
{
     public class FactoryDbContext : DbContext
    {
        public DbSet<Address_Employees>address_Employees { get; set; }
        public DbSet<Address_Costumers>Address_Costumers{ get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Costumers> Costumers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<Orderitems> Orderitems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FactoryDB;Trusted_Connection=True;MultipleActiveResultSets=true;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Addresses_Costumers_Config());
            modelBuilder.ApplyConfiguration(new Addresses_Employees_Config());
            modelBuilder.ApplyConfiguration(new Brand_Config());
            modelBuilder.ApplyConfiguration(new Categories_Config());
            modelBuilder.ApplyConfiguration(new Costumers_Config());
            modelBuilder.ApplyConfiguration(new Employess_Confi());
            modelBuilder.ApplyConfiguration(new Items_Config());
            modelBuilder.ApplyConfiguration(new Orders_Config());
            modelBuilder.ApplyConfiguration(new Ordersitems_Config());
            modelBuilder.ApplyConfiguration(new Shifts_config());
        }
    }


}
