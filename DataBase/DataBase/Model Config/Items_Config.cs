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
    class Items_Config : IEntityTypeConfiguration<Items>
    {
        public void Configure(EntityTypeBuilder<Items> builder)
        {
            builder.HasKey(i => i.Item_ID);
            builder.Property(i => i.Item_ID).HasColumnName("Item Id");
            builder.Property(i => i.Item_Name).IsRequired().HasColumnName("Item Name")
        }
    }
}
