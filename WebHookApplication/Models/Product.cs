using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
            ProductVariants = new HashSet<ProductVariant>();
        }

        public int Id { get; set; }
        public string Sku { get; set; }
        public long? ItemShopeeId { get; set; }
        public long? VariationShopeeId { get; set; }
        public string ItemShopeeSku { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public decimal? SellingPriceShopee { get; set; }
        public decimal? SellingPriceSendo { get; set; }
        public decimal? SellingPriceLazada { get; set; }
        public decimal? SellingPricePage { get; set; }
        public decimal? SellingPriceWeb { get; set; }
        public decimal? SellingPriceDetail { get; set; }
        public int? CategoryId { get; set; }
        public int? LifeCycle { get; set; }
        public byte? CategoryLifeCycleId { get; set; }
        public string Tag { get; set; }
        public int? ParentId { get; set; }
        public bool? IsClose { get; set; }
        public int? AccountId { get; set; }
        public byte? StatusId { get; set; }
        public string LinkProductShopee { get; set; }
        public string LinkProductSendo { get; set; }
        public string LinkProductLazada { get; set; }
        public string LinkProductPage { get; set; }
        public string LinkProductWeb { get; set; }
        public string LinkProductZaloPage { get; set; }
        public bool? IsVariation { get; set; }
        public int? VariationInProductId { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
