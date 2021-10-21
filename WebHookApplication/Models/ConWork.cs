using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ConWork
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateCalendar { get; set; }
        public DateTime? DateComplete { get; set; }
        public byte? ActivityNextId { get; set; }
        public byte? ActivityId { get; set; }
        public short? ResultId { get; set; }
        public short? ReasonId { get; set; }
        public short? PipelineId { get; set; }
        public bool? IsStatus { get; set; }
        public int? StaffId { get; set; }
        public int? StaffCompleteId { get; set; }
        public int? Point { get; set; }
        public string Note { get; set; }
    }
}
