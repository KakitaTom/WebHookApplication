using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ShopReplyFeedback
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public string FeedbackReview { get; set; }
        public string MessageShopee { get; set; }
        public int? NunberOfStars { get; set; }
        public bool? IsActiveFeedback { get; set; }
        public bool? IsActiveShopee { get; set; }
        public int AccountId { get; set; }
        public string MessageSms { get; set; }
        public bool? IsActiveSms { get; set; }
        public string MessageZalo { get; set; }
        public bool? IsActiveZalo { get; set; }
        public int? ShopIdZalo { get; set; }
    }
}
