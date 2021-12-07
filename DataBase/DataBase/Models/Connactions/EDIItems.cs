using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models.Connactions
{
    public class EDIItems
    {
        public int Item_Id { get; set; }
        public Items Items { get; set; }
        public int EDI_Id { get; set; }
        public EDI EDI { get; set; }
        public int Quantity { get; set; }
        public int? QuantityArrived { get; set; }
    }
}
