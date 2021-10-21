using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class LatestShopOrder
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public DateTime? LatestOrder { get; set; }
    }
}
