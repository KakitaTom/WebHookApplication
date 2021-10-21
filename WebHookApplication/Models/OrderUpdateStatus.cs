using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class OrderUpdateStatus
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string OrderCode { get; set; }
        public string Phone { get; set; }
        public int? ShopId { get; set; }
        public int? ShopeeId { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int AccountId { get; set; }
    }
}
