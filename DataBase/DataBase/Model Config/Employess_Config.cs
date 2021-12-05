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
    class Employess_Confi : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(c => c.First_Name).HasColumnName("First Name").IsRequired().HasMaxLength(25).HasColumnType("nvarchar");
            builder.Property(c => c.last_Name).HasColumnName("Last Name").IsRequired().HasMaxLength(25).HasColumnType("nvarchar");
            builder.Property(c => c.Birthdate).IsRequired().HasColumnType("smalldatetime");
            builder.Property(c => c.Hire_Date).IsRequired().HasColumnType("smalldatetime").HasColumnName("Hire Date");
            builder.Property(c => c.Phone_Number).IsRequired().HasColumnName("Phone number");
            builder.Property(c => c.Is_Manager).HasColumnType("smallint").IsRequired();
            builder.Property(c => c.Password).IsRequired().HasMaxLength(100);
            builder.HasOne(a => a.Address).WithOne(a => a.employee);
            builder.HasMany(s => s.Shifts).WithOne(e => e.Employee).HasForeignKey(e => e.Employee_ID);
            builder.HasMany(i => i.EDIs).WithOne(i => i.employee).HasForeignKey(i => i.EDI_Id);

        }
    }
}
