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
       
        public int Order_ID { get; set; }

        public int Costumer_ID { get; set; }
      
        public int Employee_ID { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Ship_Date { get; set; }
        public double Total_Cost { get; set; }
        public double Total_Weiget { get; set; }
        public string Costumer_Email { get; set; }

        public string Costumer_Address { get; set; }
        public ICollection<Orderitems> items { get; set; }
        public Employees employee { get; set; }
        public Costumers costumer { get; set; }

    }
}
