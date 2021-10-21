using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendSumOfMonth
    {
        public short Id { get; set; }
        public short? Month { get; set; }
        public short? Year { get; set; }
        public short? SumSms { get; set; }
        public short? SumEmail { get; set; }
        public int? AccountId { get; set; }
    }
}
