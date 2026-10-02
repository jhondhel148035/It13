
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementDev.Models
{
    public class PurchaseOrderItem : BaseEntity
    {
        public int PurchaseOrderId { get; set; }
        public PurchaseOrder? PurchaseOrder { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int QuantityOrdered { get; set; }
        public int QuantityReceived { get; set; }
        public decimal UnitCost { get; set; }
    }
}