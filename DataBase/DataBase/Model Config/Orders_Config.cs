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
    class Orders_Config : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(o => o.Order_ID);
            builder.Property(o => o.Order_ID).HasColumnName("Order Id");
            builder.Property(o => o.Employee_ID).HasColumnName("Employee Id");
            builder.Property(o => o.Costumer_ID).HasColumnName("Costumer Id");
            builder.Property(o => o.Order_Date).HasColumnName("Order Date").HasColumnType("smalldatetime");
            builder.Property(o => o.Ship_Date).HasColumnName("Ship Date").HasColumnType("smalldatetime");
            builder.Property(o => o.Total_Cost).HasColumnName("Total Cost").HasColumnType("float");
            builder.Property(o => o.Total_Weiget).HasColumnName("Total Weight").HasColumnType("float");
            builder.Property(o => o.Costumer_Email).HasColumnName("Costumer E-mail").HasColumnType("Nvarchar").HasMaxLength(50);
            builder.Property(o => o.Costumer_Address).HasColumnName("Costumer Address").HasColumnType("Nvarchar").HasMaxLength(70);
            builder.HasOne(e => e.employee).WithMany(e => e.Orders).HasForeignKey(e => e.Employee_ID);
            builder.HasOne(e => e.costumer).WithMany(e => e.Orders).HasForeignKey(e => e.Costumer_ID);

        }
    }
}
