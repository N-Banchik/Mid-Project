using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
   public class Shifts
    {
        public int Shift_ID { 
            get; set; }
        public int Employee_ID { get; set; }
        public DateTime Shift_Start { get; set; }
        public DateTime? Shift_End { get; set; }
        public double Total_Time { get; set; }


        public Employees Employee { get; set; }


    }
}
