using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailConfigSmsPartner
    {
        public byte Id { get; set; }
        public string PartnerName { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public int? AccountId { get; set; }
    }
}
