using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
   public class Brands
    {
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public string Manufacturing_Country { get; set; }
        public ICollection<Items> Items { get; set; }

    }
}
