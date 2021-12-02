using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Order_Master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_No { get; set; }

        public DateTime Order_DateTime { get; set; }

        public DateTime Book_DateTime { get; set; }

        public int Party_Size { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Order_Status { get; set; }

        //ForeignKey .. 

        [Display(Name = "Customer")]
        public virtual int Cus_Id { get; set; }

        [ForeignKey("Cus_Id")]
        public virtual Customer Customer { get; set; }


        public ICollection<Order_food_Detail> Order_Food_Details { get; set; }
        public ICollection<Order_Deal_Details> Order_Deal_Details { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Order_Table> Order_Tables { get; set; }

         public ICollection<Payment> Payments { get; set; }
    }
}
