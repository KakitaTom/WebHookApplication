using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailTriggerType
    {
        public MailTriggerType()
        {
            MailTriggerTypeInputs = new HashSet<MailTriggerTypeInput>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IdString { get; set; }

        public virtual ICollection<MailTriggerTypeInput> MailTriggerTypeInputs { get; set; }
    }
}
