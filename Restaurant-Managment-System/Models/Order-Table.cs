﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Managment_System.Models
{
    public class Order_Table
    {
        [Key]
        [Column(Order = 1)]
        public int Order_No { get; set; }
 
        [Key]
        [Column (Order = 2)]
        public int Table_No { get; set; }

        [ForeignKey("Order_No")]
        public Order_Master Order_Master { get; set; }

        [ForeignKey("Table_No")]
        public  Table Table { get; set; }

    }
}
