using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Rating
    {
        [Key]
        [Column (Order = 1)]
        public int Order_No { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Food_Id { get; set; }

        [ForeignKey("Order_No")]
        public Order_Master Order_Master { get; set; }

        [ForeignKey("Food_Id")]
        public Food Food { get; set; }

        public int Star { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string Comment { get; set; }




    }
}
