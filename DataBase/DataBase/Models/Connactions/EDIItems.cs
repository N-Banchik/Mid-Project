using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models.Connactions
{
    class EDIItems
    {
        public int Item_Id { get; set; }
        public Items Items { get; set; }
        public int EDI_Id { get; set; }
        public EDI EDI { get; set; }
    }
}
