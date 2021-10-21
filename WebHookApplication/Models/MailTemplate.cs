using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailTemplate
    {
        public int Id { get; set; }
        public int? TriggerType { get; set; }
        public int? SendingTemplateId { get; set; }
        public int? FilterGroupContactId { get; set; }
        public int? FilterGroupTriggerId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public int? AccountId { get; set; }
        public string TemplateCategory { get; set; }
    }
}
