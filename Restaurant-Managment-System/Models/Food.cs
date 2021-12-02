using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Food_Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Food_Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Food_Desc { get; set; }


        public double Price_current { get; set; }


        public int Person_Serve { get; set; }

        
        //ForeignKey .. 

        [Display(Name = "Measurement-Unit")]
        public virtual int UOM_Id  { get; set; }

         [ForeignKey("UOM_Id")] 
        public virtual Measurement_Unit Measurement_unit { get; set; }

        [Display(Name = "Food_Category")]
        public virtual int Cat_Id { get; set; }

       
        [ForeignKey("Cat_Id")]
        public virtual Food_Category Food_Category { get; set; }

        [Display(Name = "Discount")]
        public virtual int Dis_Id { get; set; }

        [ForeignKey("Dis_Id")]
        public virtual Discount Discount { get; set; }

        //public ICollection<Deal_Detail> Deal_Details { get; set; }
        public ICollection<Images> Images { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Order_food_Detail> Order_Food_Details { get; set; }
     

    }
}
