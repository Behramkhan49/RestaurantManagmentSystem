using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Managment_System.Models
{
    public class Opening_Hours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Opn_Id { get; set;}

        [Column(TypeName = "varchar(15)")]
        public string  Day { get; set;}

        
        public DateTime   From_Time { get; set;}

        [Column(TypeName = "DateTime")]
        public DateTime  To_Time { get; set;}

    }
}
