using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    class In_EDI
    {
        [Key]
        public int EDI_Id { get; set; }
        public DateTime Date { get; set; }
        public double Total_Weight { get; set; }
        public int Total_Items { get; set; }
        public string Approved_By { get; set; }
        public ICollection<Items> Items { get; set; }





    }
}
