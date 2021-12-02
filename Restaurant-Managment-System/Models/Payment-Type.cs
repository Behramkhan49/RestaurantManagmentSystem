using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Payment_Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pay_Type_Id { get; set;}

        [Column(TypeName = "varchar(15)")]
        public string Pay_Type_Desc { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
