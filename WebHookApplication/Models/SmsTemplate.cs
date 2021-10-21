using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class SmsTemplate
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string ContentSms { get; set; }
        public int? StaffCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
