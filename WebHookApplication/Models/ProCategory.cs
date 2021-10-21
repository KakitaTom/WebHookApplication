using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ProCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short? ParentId { get; set; }
        public bool? IsClose { get; set; }
        public int? AccountId { get; set; }
        public int? ShopId { get; set; }
    }
}
