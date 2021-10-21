using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendingEventType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SendingEvent { get; set; }
        public string SendingType { get; set; }
        public string ParentEventType { get; set; }
    }
}
