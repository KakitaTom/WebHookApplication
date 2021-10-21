using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ProductVariant
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? ProductId { get; set; }
        public string Sku { get; set; }
        public decimal? SellingPriceShopee { get; set; }
        public decimal? SellingPriceLazada { get; set; }
        public byte? StatusId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Product Product { get; set; }
    }
}
