using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendingContactStatusByEventType
    {
        public byte? Id { get; set; }
        public string Name { get; set; }
        public string SendingEventTypeId { get; set; }
    }
}
