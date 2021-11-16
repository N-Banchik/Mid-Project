using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    class Address
    {
        public int User_ID { get; set; }
        public string Street_Name { get; set; }
        public int House_Number { get; set; }

        public int Apartment { get; set; }
    }
}
