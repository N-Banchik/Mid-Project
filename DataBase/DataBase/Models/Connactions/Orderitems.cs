using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace DataBase.Models
{
   public class Orderitems
    {
        public int ID { get; set; }
        public int Itme_Id { get; set; }
        public Items Item { get; set; }
        public int Order_id { get; set; }
        public Orders Order { get; set; }
        public int Quantity { get; set; }
    }
}
