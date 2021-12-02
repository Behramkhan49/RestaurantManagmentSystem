using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Receipt_No { get; set; }

        [Display(Name = "Order_Master")]
        public virtual int Order_No { get; set; }

        [ForeignKey("Order_No")]
        public virtual Order_Master Order_Master { get; set; }

        public DateTime Pay_DateTime { get; set; }

        [Display(Name = "Payment_Type")]
        public virtual int Pay_Type_Id { get; set; }

        [ForeignKey("Pay_Type_Id")]
        public virtual Payment_Type Payment_Type { get; set; }

        [Display(Name = "Discount")]
        public virtual int Dis_Id { get; set; }

        [ForeignKey("Dis_Id")]
        public virtual Discount Discount { get; set; }

        public double Dis_Amount { get; set; }

        public double Ammount { get; set; }


    }
}
