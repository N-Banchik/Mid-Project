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
    class Shifts_config : IEntityTypeConfiguration<Shifts>
    {
        public void Configure(EntityTypeBuilder<Shifts> builder)
        {
            builder.HasKey(k => k.Shift_ID);
            builder.Property(t => t.Total_Time).HasColumnName("Shift Time");
            builder.Property(ss => ss.Shift_Start).HasColumnName("Shift start time").HasColumnType("smalldatetime");
            builder.Property(se => se.Shift_End).HasColumnName("Shift end time").HasColumnType("smalldatetime");
            builder.HasOne(e => e.Employee)
                .WithMany(s => s.Shifts)
                .HasForeignKey(e => e.Employee_ID);
        }
    }
}
