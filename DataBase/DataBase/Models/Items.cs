using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Models
{
   public class Items
    {
        
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public int Category_Id { get; set; }
        public int Brand_Id{ get; set; }
        public double Weight { get; set; }
        public int Units_In_Inventory { get; set; }
        public int Minimum_Units_In_Inventory { get; set; }
        public double Price { get; set; }

        public Categories Category { get; set; }
        public Brands Brand { get; set; }
        public ICollection<EDI> EDIs { get; set; }
    }
}
