using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailLink
    {
        public int Id { get; set; }
        public int? MessageId { get; set; }
        public string Link { get; set; }
        public string ShortenLink { get; set; }
        public bool? IsClick { get; set; }
        public int? ClickTime { get; set; }
        public string AccountCode { get; set; }
        public string Replaced { get; set; }
        public int? ReplacedId { get; set; }
    }
}
