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
    class Ordersitems_Config : IEntityTypeConfiguration<Orderitems>
    {
        public void Configure(EntityTypeBuilder<Orderitems> builder)
        {
            builder.HasKey(k => k.ID);
            builder.HasOne(i => i.Item).WithMany(o => o.Orders).HasForeignKey(i => i.Itme_Id);
            builder.HasOne(o => o.Order).WithMany(i => i.items).HasForeignKey(o => o.Order_id);
        }
    }
}
