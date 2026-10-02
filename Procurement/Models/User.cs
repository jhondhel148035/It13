using System;

namespace ProcurementDev.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "Staff";
    }
}
