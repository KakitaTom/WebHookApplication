using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class SmsSendingContact
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? DealsId { get; set; }
        public int? OrderId { get; set; }
        public int? SendingId { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public DateTime? DateSend { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffCreate { get; set; }
        public byte? ActionTypeContact { get; set; }
        public DateTime? DateActionContact { get; set; }
        public byte? Status { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Order Order { get; set; }
        public virtual SmsSending Sending { get; set; }
    }
}
