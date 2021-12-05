using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DataBase.Models
{
    
  public  class Costumers
    {
        
        public int Costumer_ID { get; set; }
        public string First_Name { get; set; }
        public string last_Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
        public ICollection<Address_Costumers> Address { get; set; }


    }
}
