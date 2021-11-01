using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHookApplication.ViewModel
{
    public class WebhookView
    {
        public int id { get; set; }
        public string message { get; set; }
        public List<DataWebhook> dataWebhook { get; set; }
        public DateTime dateCreated { get; set; }
        public string source { get; set; }
        public string sourceCategory { get; set; }
    }

    public class DataWebhook
    {
        public long eventId { get; set; }
        public int subscriptionId { get; set; }
        public int portalId { get; set; }
        public int appId { get; set; }
        public long occurredAt { get; set; }
        public string subscriptionType { get; set; }
        public int attemptNumber { get; set; }
        public int objectId { get; set; }
        public string changeFlag { get; set; }
        public string changeSource { get; set; }
    }
}
