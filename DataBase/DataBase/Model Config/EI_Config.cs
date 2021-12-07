using DataBase.Models.Connactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Model_Config
{
   public class EI_Config : IEntityTypeConfiguration<EDIItems>
    {
        public void Configure(EntityTypeBuilder<EDIItems> builder)
        {
            builder.HasKey(ei => new { ei.EDI_Id, ei.Item_Id });
            builder.HasOne(i => i.EDI).WithMany(i => i.Items).HasForeignKey(i => i.EDI_Id);
            builder.HasOne(i => i.Items).WithMany(i => i.EDIs).HasForeignKey(i => i.Item_Id);
        }
    }
}
