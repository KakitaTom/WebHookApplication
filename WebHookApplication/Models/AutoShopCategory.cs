using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoShopCategory
    {
        public AutoShopCategory()
        {
            AutoAutomates = new HashSet<AutoAutomate>();
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountId { get; set; }
        public string ShopType { get; set; }
        public TimeSpan? TimeInDayRunFrom { get; set; }
        public TimeSpan? TimeInDayRunTo { get; set; }
        public int? StaffId { get; set; }
        public bool? IsSystem { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<AutoAutomate> AutoAutomates { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
