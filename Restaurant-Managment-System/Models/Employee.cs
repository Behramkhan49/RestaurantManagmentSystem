using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Emp_Id { get; set; }

        [Display(Name = "Role")]
        public virtual int Role_Id {get; set;}

        [ForeignKey("Role_Id ")]
        public virtual Role Role { get; set; }

        [Column (TypeName = "varchar (15)")]
        public  string Emp_Name { get; set; }

        [Column(TypeName = "varchar (25)")]
        public  string Emp_Email { get; set; }

        [Column(TypeName = "varchar (15)")]
        public  string Emp_Password { get; set; }

        [Column(TypeName = "varchar (15)")]
        public  string Emp_contact { get; set; }


    }
}
