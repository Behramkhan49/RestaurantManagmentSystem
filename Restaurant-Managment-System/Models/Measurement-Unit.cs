using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Measurement_Unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UOM_Id { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string UOM_Desc { get; set; }


        public ICollection<Food> Foods { get; set; }

        public ICollection<Deal_Detail>  Deal_Details { get; set; }
    }
}
