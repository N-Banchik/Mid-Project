using DataBase.Models.Connactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class EDI
    {
        public int EDI_Id { get; set; }
        public DateTime Date { get; set; }
        public double Total_Weight { get; set; }
        public int Total_Items { get; set; }
        public int? Approved_By { get; set; }
        public ICollection<EDIItems> Items { get; set; }
        public Employees employee { get; set; }

    }
}
