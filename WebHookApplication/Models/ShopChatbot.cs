using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ShopChatbot
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string ResponseMessage { get; set; }
        public string LinkImage { get; set; }
        public bool? IsActive { get; set; }
        public int? ShopId { get; set; }
        public int AccountId { get; set; }
    }
}
