using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AkaBizSendEmailNoti
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ContentEmail { get; set; }
        public int? ConWorkId { get; set; }
        public int? StaffId { get; set; }
        public string TitleEmail { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public bool? Status { get; set; }
    }
}
