using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Deal_Detail
    {
        [Key]
        [Column(Order = 1)]
        public int Deal_Id { get; set; }

        public int Quantity { get; set; }

        [Key]
        [Column (Order = 2)]
        public virtual int Food_Id { get; set; }

        [ForeignKey("Deal_Id")]
        public Deal_Master Deal_Master { get; set; }

        [ForeignKey("Food_Id")]
        public virtual Food Food { get; set; }

        [Display(Name = "Measurement_Unit")]
        public virtual int UOM_Id { get; set; }

        [ForeignKey("UOM_Id")]
        public virtual Measurement_Unit Measurement_Unit { get; set; }


       
    }
}
