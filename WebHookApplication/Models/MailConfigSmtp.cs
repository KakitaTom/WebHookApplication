using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailConfigSmtp
    {
        public MailConfigSmtp()
        {
            MailSendingConfigSmtps = new HashSet<MailSendingConfigSmtp>();
        }

        public int Id { get; set; }
        public string EmailType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public bool? EnableSsl { get; set; }
        public int? Port { get; set; }
        public int? SendMax { get; set; }
        public bool? IsClose { get; set; }
        public bool? IsActivity { get; set; }
        public bool? IsCheckActivity { get; set; }
        public string BrandName { get; set; }
        public int? StaffCreateId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateModify { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<MailSendingConfigSmtp> MailSendingConfigSmtps { get; set; }
    }
}
