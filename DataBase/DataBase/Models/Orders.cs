using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Models
{
    class Orders
    {
        [Key]
        [Column("Order Number")]
        public int Order_ID { get; set; }
        [ForeignKey("Costumer ID")]
        [Column("Costumer ID")]
        public int Costumer_ID { get; set; }
        [ForeignKey("Employee ID")]
        [Column("Employee ID")]
        public int Employee_ID { get; set; }

        public string Costumer_Address { get; set; }



        public Employees employee_Id { get; set; }
        public Costumers costumer_Id { get; set; }

    }
}
