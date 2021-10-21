using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoShopNotification
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public string Notify { get; set; }
        public string Type { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? IsRead { get; set; }
        public int? AccountId { get; set; }
        public int? StaffId { get; set; }
    }
}
