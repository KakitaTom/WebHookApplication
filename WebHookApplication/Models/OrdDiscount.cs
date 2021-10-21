using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class OrdDiscount
    {
        public int Id { get; set; }
        public long? DiscountId { get; set; }
        public string DiscountName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Status { get; set; }
    }
}
