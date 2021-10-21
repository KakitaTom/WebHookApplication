using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoShopContact
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactKey { get; set; }
        public int ShopId { get; set; }
        public string Uid { get; set; }
        public string Type { get; set; }
        public int? ParentId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
