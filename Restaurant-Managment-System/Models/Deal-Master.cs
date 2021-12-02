using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Deal_Master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Deal_Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Deal_Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Deal_Desc { get; set; }

        public double Price_current { get; set; }


        public int Person_Serve { get; set; }

        //Foreign Key .. 
        [Display (Name = " Discount")]
        public virtual int Dis_Id { get; set; }

        [ForeignKey("Dis_Id")]
        public virtual Discount Discount { get; set; }


        public ICollection<Images> Images { get; set; }
        public Deal_Detail Deal_Details { get; set; }
        public ICollection<Order_Deal_Details> Order_Deal_Details  { get; set; }

    }
}
