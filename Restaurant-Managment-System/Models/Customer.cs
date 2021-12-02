using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cust_Id { get; set; }

        [Column(TypeName ="varchar(15)")]
        public string Cust_Name { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cust_NIC { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Cust_Email { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cust_Password { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cust_Contact { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cust_Address { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Cust_City { get; set; }    


        public ICollection<Order_Master> Order_Masters { get; set; }

    }
}
