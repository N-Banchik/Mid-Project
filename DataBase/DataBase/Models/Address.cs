using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataBase.Models
{
    class Address
    {

        [ForeignKey("Costumer ID")]
        [Column("Costumer ID")]
        public int Costumer_ID { get; set; }
        [ForeignKey("Employee ID")]
        [Column("Employee ID")]
        public int Employee_ID { get; set; }
        public string Street_Name { get; set; }
        public int House_Number { get; set; }
        public int Apartment_Number { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }

        public Costumers costumer { get; set; }
        public Employees employee { get; set; }


        public override string ToString()
        {
            if (costumer != null)
            {
                return ($"{costumer.First_Name+" "+costumer.last_Name},{House_Number}, {Street_Name},\n {Zipcode} {City}.");

            }
            if (employee != null)
            {
                return ($"{employee.First_Name + " " + costumer.last_Name},{House_Number}, {Street_Name},\n {Zipcode} {City}.");

            }
            return "";
        }

    }
}
