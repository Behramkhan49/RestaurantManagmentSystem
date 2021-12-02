using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Food_Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cat_Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cat_Name { get; set; }

        public ICollection<Food> foods { get; set; }
    }
}
