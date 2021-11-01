using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebHookApplication.Models;
using WebHookApplication.ViewModel;

namespace WebHookApplication.Service
{
    public class WebhookService
    {
        public int Create(WebhookView webhookViewPam)
        {
            try
            {
                using (var db = new akaBizAutoDbContext())
                {
                    var webhook = new Webhook()
                    {
                        Message = webhookViewPam.message,
                        DateCreate = webhookViewPam.dateCreated,
                        Source = webhookViewPam.source,
                        SourceCategory = webhookViewPam.sourceCategory
                    };

                    db.Webhooks.Add(webhook);
                    db.SaveChanges();
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
//
        public List<Webhook> GetALL()
        {
            using (var db = new akaBizAutoDbContext())
            {
                return db.Webhooks.ToList();

            }
        }
    }
}
