using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dis_Id { get; set; }

        public string Dis_Code { get; set; }

        //Foreign Key .. 
        [Display(Name = "Discount_Type")]
        public virtual int Dis_Type_Id { get; set; }

        [ForeignKey("Dis_Type_Id")]
        public virtual Discount_Type discounts { get; set; }

        public DateTime From_Date { get; set; }


        public DateTime To_Date { get; set; }


        public DateTime From_Time { get; set; }


        public DateTime To_Time { get; set; }


        public double  Discount_Value { get; set; }


        public double  Min_Purchase { get; set; }

        public ICollection<Payment> Payments { get; set; }
         public ICollection <Deal_Master> Deal_Masters { get; set; }
        public ICollection<Food> Foods { get; set; }
  
    }
}
