
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementDev.Models
{
    public class Product : BaseEntity
    {
        public string SKU { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string Colorway { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;

        public Inventory? Inventory { get; set; }
    }
}