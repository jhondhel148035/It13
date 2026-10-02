
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementDev.Models
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
    }
}