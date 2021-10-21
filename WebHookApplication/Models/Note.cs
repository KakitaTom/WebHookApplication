using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? ContactId { get; set; }
        public int? PipelineId { get; set; }
        public int? AccountId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffId { get; set; }
    }
}
