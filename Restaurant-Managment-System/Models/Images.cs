using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Images
    {
        [Key]
        public byte[] Image_Url { get; set; }
       
        [Display(Name = "Food")]
        public virtual int Food_Id { get; set; }
        [ForeignKey("Food_Id")]
        public virtual Food Food { get; set; }
        
        [Display(Name = "Deal_Master ")]
        public virtual int Deal_Id { get; set; }

        [ForeignKey("Deal_Id")]
        public virtual Deal_Master Deal_Master { get; set; }

        [Display(Name = "Location")]
        public virtual int Loc_Id { get; set; }

        [ForeignKey("Loc_Id")]
       public virtual Location Location { get; set; }


       
    }
}
