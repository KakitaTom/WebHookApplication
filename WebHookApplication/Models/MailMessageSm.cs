using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailMessageSm
    {
        public int Id { get; set; }
        public string SenderPhoneNumber { get; set; }
        public string ShopPhoneNumber { get; set; }
        public int? AccountId { get; set; }
        public string Message { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual Account Account { get; set; }
    }
}
