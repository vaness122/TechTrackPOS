using ByteTech.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DiscountType DiscountType { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int? MinimumOrderAmount { get; set; }
        public int? MaximumDiscountAmount { get; set; }
        public int UsageLimit { get; set; }
        public int UsageCount { get; set; } = 0;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
