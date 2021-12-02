using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Loc_Id { get; set; }

        [Column(TypeName ="varchar(15)")]
        public string Loc_Name { get; set; }



        public ICollection<Table> Tables { get; set; }

        public ICollection<Images> Images { get; set; }
    }
}
