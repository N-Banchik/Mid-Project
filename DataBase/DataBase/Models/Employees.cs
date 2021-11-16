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
        [DataType("nvarchar")]
        [MaxLength(25)]
        public string First_Name{ get; set; }
        [Required]
        [Column("Last Name")]
        [DataType("nvarchar")]
        [MaxLength(25)]
        public string last_Name { get; set; }
        [Required]
        [Column("BirthDate")]
        [DataType("smalldatetime")]
        public DateTime Birthdate{ get; set; }
        [Required]
        [Column("Hire Date")]
        [DataType("smalldatetime")]
        public DateTime Hire_Date { get; set; }
        [Required]
        [Column("Address")]
        [DataType("nvarchar")]
        [MaxLength(50)]
        public string Address{ get; set; }
        [Required]
        [Column("Phone number")]
        [DataType("nvarchar")]
        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        [Column("Manager")]
        [DataType("int")]
        public int Is_Manager{ get; set; }

        [NotMapped]
        bool Manager;


    }
}
