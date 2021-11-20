using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataBase.Model_Config
{
    class Addresses_Employees_Config : IEntityTypeConfiguration<Address_Employees>
    {
        public void Configure(EntityTypeBuilder<Address_Employees> builder)
        {
            builder.HasKey(a => a.Address_ID).HasName("Address Id");
            builder.HasOne(e => e.employee).WithOne(e => e.Address).HasForeignKey<Employees>(e=>e.ID);
            builder.Property(e => e.Employee_ID).HasColumnName("Employee Id");
            builder.Property(s => s.Street_Name).HasColumnName("Street Name").IsRequired();
            builder.Property(s => s.House_Number).HasColumnName("House Number").IsRequired();
            builder.Property(s => s.Apartment_Number).HasColumnName("Apartment Number").IsRequired();
            builder.Property(s => s.Zipcode).HasColumnName("Zipcode").IsRequired();
            builder.Property(s => s.City).HasColumnName("City").IsRequired();
        }
    }
}
