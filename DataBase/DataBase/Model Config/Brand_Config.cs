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
    class Brand_Config : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> builder)
        {
            builder.HasKey(b => b.Brand_Id);
            builder.Property(b => b.Brand_Id).HasColumnName("Brand Id");
            builder.Property(b => b.Brand_Name).HasColumnName("Brand Name").HasColumnType("nvarchar").HasMaxLength(25);
            builder.Property(b => b.Manufacturing_Country).HasColumnName("Manufacturing Country").HasColumnType("nvarchar").HasMaxLength(25);
            builder.HasMany(i => i.Items).WithOne(b => b.Brand).HasForeignKey(b=>b.Brand_Id);

        }
    }
}
