using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class SmsSending
    {
        public SmsSending()
        {
            SmsSendingContacts = new HashSet<SmsSendingContact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentSms { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public byte? TypeSms { get; set; }
        public int? StaffCreate { get; set; }
        public int? StaffModify { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? IsClose { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<SmsSendingContact> SmsSendingContacts { get; set; }
    }
}
