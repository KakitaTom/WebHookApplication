using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class PhoneNumberReceive
    {
        public string Phone { get; set; }
        public int? AccountId { get; set; }
        public bool? IsSystem { get; set; }
    }
}
