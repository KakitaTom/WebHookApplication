using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Keyword
    {
        public Keyword()
        {
            MailTriggers = new HashSet<MailTrigger>();
        }

        public int Id { get; set; }
        public string Keyword1 { get; set; }
        public int AccountId { get; set; }

        public virtual ICollection<MailTrigger> MailTriggers { get; set; }
    }
}
