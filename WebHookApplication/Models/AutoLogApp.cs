using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoLogApp
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string ModuleName { get; set; }
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
        public string ActionName { get; set; }
        public string Describe { get; set; }
        public string Exception { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffId { get; set; }
    }
}
