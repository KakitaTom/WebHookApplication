using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailDeviceMobile
    {
        public int Id { get; set; }
        public string Device { get; set; }
        public int? SendMaxOfDay { get; set; }
        public int? AccountId { get; set; }
        public string Mobile { get; set; }
    }
}
