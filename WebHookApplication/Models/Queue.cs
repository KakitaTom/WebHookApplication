using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Queue
    {
        public int Id { get; set; }
        public string Events { get; set; }
        public string Source { get; set; }
        public DateTime? DateCreate { get; set; }
        public string QueueCode { get; set; }
        public string SubscriptionType { get; set; }
        public string AckId { get; set; }
    }
}
