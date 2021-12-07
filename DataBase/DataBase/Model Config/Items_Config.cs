using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using DataBase.Models.Connactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.Model_Config
{
    class Items_Config : IEntityTypeConfiguration<Items>
    {
        public void Configure(EntityTypeBuilder<Items> builder)
        {
            builder.HasKey(i => i.Item_ID);
            builder.Property(i => i.Item_ID).HasColumnName("Item Id");
            builder.Property(i => i.Item_Name).IsRequired().HasColumnName("Item Name");
            builder.Property(i => i.Category_Id).IsRequired().HasColumnName("Category Id");
            builder.Property(i => i.Brand_Id).IsRequired().HasColumnName("Brand Id");
            builder.Property(i => i.Units_In_Inventory).IsRequired().HasColumnName("Units In inventory");
            builder.Property(i => i.Minimum_Units_In_Inventory).IsRequired().HasColumnName("Minimum Units In inventory");
            builder.Property(i => i.Weight).IsRequired().HasColumnName("Weight").HasColumnType("float");
            builder.Property(i => i.Price).IsRequired().HasColumnName("Unit Price").HasColumnType("smallmoney");
            builder.HasOne(c => c.Category).WithMany(i => i.item).HasForeignKey(i => i.Category_Id);
            builder.HasOne(c => c.Brand).WithMany(i => i.Items).HasForeignKey(i => i.Brand_Id);
        }
    }
}
