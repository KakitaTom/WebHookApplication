using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Condition
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? StaffCreateId { get; set; }
        public int? StaffModify { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string ConditionTable { get; set; }
        public string ConditionFields { get; set; }
        public string ConditionType { get; set; }
        public string ConditionValue { get; set; }
        public string ConditionRelationship { get; set; }
        public int? SendingId { get; set; }

        public virtual MailSending Sending { get; set; }
    }
}
