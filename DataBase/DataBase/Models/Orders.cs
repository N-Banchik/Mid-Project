using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Models
{
    class Orders
    {
        [Key]
        [Column("Order Number")]
        public int Order_ID { get; set; }

    }
}
