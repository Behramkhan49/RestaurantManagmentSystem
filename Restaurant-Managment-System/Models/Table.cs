using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Table_No { get; set; }

        [Column(TypeName ="varchar(15)")]
        public string Table_Name { get; set; }

        public int seat { get; set; }

        [Column (TypeName ="varchar(10)")]
        public string Priority { get; set; }

        public int Occupied { get; set; }

        //Foreign Key
        [Display(Name ="Location")]
        public virtual int Loc_Id { get; set; }

        [ForeignKey("Loc_Id")]
        public virtual Location Location { get; set; }

        public ICollection<Order_Table> Order_Tables { get; set; }

    }
}
