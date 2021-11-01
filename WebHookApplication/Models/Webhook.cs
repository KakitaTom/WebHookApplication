using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Webhook
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Type { get; set; }
        public string SourceCategory { get; set; }
        public bool? IsUpdated { get; set; }
    }
}
