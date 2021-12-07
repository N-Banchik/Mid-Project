using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.Model_Config
{
    class EDI_Config : IEntityTypeConfiguration<EDI>
    {
        public void Configure(EntityTypeBuilder<EDI> builder)
        {
            builder.HasKey(i => i.EDI_Id);
            builder.HasOne(i => i.employee).WithMany(i => i.EDIs).HasForeignKey(i=>i.Approved_By);
            
        }
    }
}
