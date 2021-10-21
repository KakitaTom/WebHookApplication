using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailComment
    {
        public int Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public int ShopId { get; set; }
        public int AccountId { get; set; }
        public int OrderId { get; set; }
        public int ContactId { get; set; }
        public long CommentShopeeId { get; set; }
        public string BuyerUsername { get; set; }
        public long? ItemId { get; set; }
        public int? VariationId { get; set; }
        public int? RatingStar { get; set; }
        public string Reply { get; set; }
        public string Comment { get; set; }
        public string OrderCode { get; set; }
        public string Source { get; set; }
        public DateTime? DateCreateComment { get; set; }
        public string CommentStatus { get; set; }
        public string ReplyStatus { get; set; }
        public string Mobile { get; set; }
        public long? ShopeeId { get; set; }
    }
}
