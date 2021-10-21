using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DeaResult
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public byte? NextDay { get; set; }
        public bool? IsClose { get; set; }
        public int? AccountId { get; set; }
        public string Status { get; set; }
    }
}
