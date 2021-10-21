using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailLinkContentTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? ContentTemplateId { get; set; }

        public virtual MailContentTemplate ContentTemplate { get; set; }
    }
}
