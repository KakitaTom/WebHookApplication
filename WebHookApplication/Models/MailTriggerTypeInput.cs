using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailTriggerTypeInput
    {
        public int Id { get; set; }
        public int TriggerTypeId { get; set; }
        public string Description { get; set; }
        public string Datatype { get; set; }

        public virtual MailTriggerType TriggerType { get; set; }
    }
}
