using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FileDetail
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string AzureUniquename { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? TagId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsImport { get; set; }
    }
}
