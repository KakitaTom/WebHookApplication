using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHookApplication.ViewModel
{
    public class WebhookView
    {
        public int Id { get; set; }
        public string DataWebhook { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
