using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class OrderProduct
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public short? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? DiscountCash { get; set; }
        public double? DiscountPercent { get; set; }
        public string PromotionType { get; set; }
        public long? PromotionId { get; set; }
        public int? ProductVariantId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
