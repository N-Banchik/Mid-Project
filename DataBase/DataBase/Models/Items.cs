using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Models
{
    class Items
    {
        [Key]
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        [ForeignKey("Category Id")]
        public string Category_Id { get; set; }
        public double Weight { get; set; }
        public int Units_In_Inventory { get; set; }
        [DataType("money")]
        public double Price { get; set; }

        public Categories Category { get; set; }
        public Brands Brand { get; set; }
        public ICollection<Orderitems> Orders { get; set; }

    }
}
