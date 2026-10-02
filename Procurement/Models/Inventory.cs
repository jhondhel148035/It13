
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementDev.Models
{
    public class Inventory : BaseEntity
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int QuantityOnHand { get; set; }
    }
}