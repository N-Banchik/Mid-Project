using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    [Table("Employees_TB")]
    class Employees
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("First Name")]
        [DataType("Nvarchar")]
        [MaxLength(25)]
        public string First_Name{ get; set; }
        [Required]
        [Column("Last Name")]
        [DataType("Nvarchar")]
        [MaxLength(25)]
        public string last_Name { get; set; }
        [Required]
        [Column("BirthDate")]
        [DataType("smalldatetime")]
        public DateTime Birthdate{ get; set; }
        public int MyProperty { get; set; }

        [Required]
        [Column("Manager")]
        [DataType("int")]
        public int Is_Manager{ get; set; }

    }
}
