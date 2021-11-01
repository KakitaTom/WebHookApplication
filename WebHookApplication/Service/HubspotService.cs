using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WebHookApplication.Global;
using WebHookApplication.Models;
using WebHookApplication.ViewModel;

namespace WebHookApplication.Service
{
    public class HubspotService
    {
        private ContactService _contactService;
        private WebhookService _webhookService;

        public HubspotService()
        {
            _webhookService = new WebhookService();
            _contactService = new ContactService();
        }

        public void VerifyPush(string jsonString)
        {
            var contact = JsonConvert.DeserializeObject<List<DataWebhook>>(jsonString);
            ContactViewModel contactViewModel = new ContactViewModel();
            WebhookView webhookView = new WebhookView();
            webhookView.message = jsonString;
            webhookView.dateCreated = DateTime.Now;
            webhookView.source = "hubspot";
            webhookView.sourceCategory = contact[0].subscriptionType;
            _webhookService.Create(webhookView);

            using (null)
            {
                //                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts/" + contact[0].objectId + "?archived=false");
                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts/" + contact[0].objectId + "?properties=firstname%2Clastname%2Cphone%2Cemail%2Chs_analytics_source%2Chs_analytics_source_data_1%2Chs_analytics_source_data_2%2Chs_analytics_first_url%2Chs_analytics_last_url%2Chs_analytics_first_referrer%2Chs_analytics_last_referrer%2Chs_analytics_average_page_views%2Crecent_conversion_event_name%2Crecent_conversion_date&archived=false");
                var request = new RestRequest(Method.GET);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
                IRestResponse response = client.Execute(request);

                contactViewModel = JsonConvert.DeserializeObject<ContactViewModel>(response.Content);
            }
            
            var newContact = new ContactViewModel()
            {
                firstname = contactViewModel.properties.firstname,
                lastname = contactViewModel.properties.lastname,
                mobile = contactViewModel.properties.phone,
                email = contactViewModel.properties.email,
                KeyWordSplit = contactViewModel.properties.hs_analytics_source + " " + contactViewModel.properties.hs_analytics_source_data_1 + " " + contactViewModel.properties.hs_analytics_source_data_2,
                Averrage_Pageviews = contactViewModel.properties.hs_analytics_average_page_views,
                Original_Sorce = contactViewModel.properties.hs_analytics_source,
                Original_Sorce_Drill_Down_1 = contactViewModel.properties.hs_analytics_source_data_1,
                Original_Sorce_Drill_Down_2 = contactViewModel.properties.hs_analytics_source_data_2,
                Last_Page_Seen = contactViewModel.properties.hs_analytics_last_url,
                First_Page_Seen  = contactViewModel.properties.hs_analytics_first_url,
                Last_Referring_Site  = contactViewModel.properties.hs_analytics_last_referrer,
                First_Referring_Site  = contactViewModel.properties.hs_analytics_first_referrer,
                Recen_Conversion = contactViewModel.properties.recent_conversion_event_name,
                Recen_Conversion_Data  = contactViewModel.properties.recent_conversion_date,
                ContactHubSpotId = contactViewModel.id.ToString(),
                Number_Of_Form_Submissions = 0,
                Source = "hubspot"
            };

            using (null)
            {
                var client = new RestClient("http://app.akabiz.net/api/contact/splitDataContact?apiKey=2654%7C0967293539");
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(newContact), ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
            }
        }
    }
}
