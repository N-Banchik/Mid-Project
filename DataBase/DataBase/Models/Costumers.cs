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
    
    class Costumers
    {
        [Key]
        [Column("ID")]
        [DataMember]
        public int Costumer_ID { get; set; }

        [Required]
        [Column("First Name")]
        [DataType("nvarchar")]
        [MaxLength(25)]
        public string First_Name { get; set; }

        [Required]
        [Column("Last Name")]
        [DataType("nvarchar")]
        [MaxLength(25)]
        public string last_Name { get; set; }

        [Required]
        [Column("BirthDate")]
        [DataType("smalldatetime")]
        public DateTime Birthdate { get; set; }

        public Address Address { get; set; }


    }
}
