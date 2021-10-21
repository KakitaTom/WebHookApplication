using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendSumOfDay
    {
        public int Id { get; set; }
        public int? SumSend { get; set; }
        public int? SumSendSms { get; set; }
        public DateTime? DateSend { get; set; }
        public int? DeviceId { get; set; }
        public int? ConfigSmtpId { get; set; }
        public int? AccountId { get; set; }
    }
}
