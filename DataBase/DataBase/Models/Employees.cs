using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    [Table("Employees")]
   public  class Employees
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string last_Name { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hire_Date { get; set; }
        public string Phone_Number { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Is_Manager { get; set; }
        bool Manager;
        public Address_Employees Address { get; set; }
        public ICollection<Shifts> Shifts { get; set; }
        public ICollection<EDI> EDIs { get; set; }


    }
}
