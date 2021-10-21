using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailContentTemplate
    {
        public MailContentTemplate()
        {
            MailLinkContentTemplates = new HashSet<MailLinkContentTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string SendingType { get; set; }
        public int? AccountId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }

        public virtual ICollection<MailLinkContentTemplate> MailLinkContentTemplates { get; set; }
    }
}
