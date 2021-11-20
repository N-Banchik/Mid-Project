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
    class Categories_Config : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(k => k.Category_ID).HasName("Category ID");
            builder.Property(n => n.Category_Name).HasColumnName("Name").IsRequired();
            builder.Property(n => n.Description).HasColumnName("Description").IsRequired();
            builder.HasMany(i => i.item).WithOne(c => c.Category).HasForeignKey(c => c.Category_Id);

        }
    }
}
