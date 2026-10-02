
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementDev.Models
{
    public class PurchaseOrder : BaseEntity
    {
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public decimal TotalCost { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public POStatus Status { get; set; } = POStatus.Draft;
        public string Notes { get; set; } = string.Empty;

        public ICollection<PurchaseOrderItem> Items { get; set; } = new List<PurchaseOrderItem>();
    }
}