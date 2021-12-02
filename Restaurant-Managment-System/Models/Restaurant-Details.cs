using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Restaurant_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Res_Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string  Res_Name { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string  Res_Area { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string  Res_Address { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string  Res_Email { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string  Res_Contact { get; set; }
        
    }
}
