using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ShopFeedback
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public byte? Star { get; set; }
        public string CustomerCode { get; set; }
        public string Feedback { get; set; }
        public int AccountId { get; set; }
    }
}
