using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendingConfigSmtp
    {
        public short Id { get; set; }
        public int? SendingId { get; set; }
        public int? ConfigSmtpId { get; set; }

        public virtual MailConfigSmtp ConfigSmtp { get; set; }
        public virtual MailSending Sending { get; set; }
    }
}
