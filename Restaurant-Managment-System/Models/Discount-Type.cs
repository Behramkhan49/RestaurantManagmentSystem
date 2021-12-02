using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Discount_Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dis_Type_Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Dis_Type_Name { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Dis_Type_Desc { get; set; }


        public ICollection<Discount> Discounts { get; set; }
    }
}
