using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using WebHookApplication.Global;
using WebHookApplication.Models;
using WebHookApplication.Service;
using WebHookApplication.ViewModel;
using ContactViewModel = WebHookApplication.ViewModel.ContactViewModel;

namespace WebHookApplication.Controllers
{
    public class ContactController : Controller
    {
        private ContactService _contactService;
        private StaffService _staffService;

        public ContactController()
        {
            _contactService = new ContactService();
            _staffService = new StaffService();
        }

        [HttpGet]
        [Route("contact/verify")]
        public IActionResult Verify()
        {
            Code code = new Code();
            return View(code);
        }

        [HttpGet]
        [Route("contact/test")]
        public IActionResult test()
        {
            using (var db = new akaBizAutoDbContext())
            {
                var str = db.Webhooks.FirstOrDefault(x => x.Source == "hubspot");
                var contact = JsonConvert.DeserializeObject<List<DataWebhook>>(str.Message);

                return Content(contact[0].objectId.ToString());
            }
        }

        [Route("contact/confirm/{code}")]
        public IActionResult Confirm(string code)
        {
            var newContact = new ContactViewModel()
            {
                firstname = "thinh",
                lastname = "hoang",
                mobile = "0987876124",
                email = "thinhhoang@gmail.com",
                KeyWordSplit = "OFFLINE " + "INTEGRATION " + "236745",
                Averrage_Pageviews = "0",
                Original_Sorce = "OFFLINE",
                Original_Sorce_Drill_Down_1 = "INTEGRATION",
                Original_Sorce_Drill_Down_2 = "236745",
                ContactHubSpotId = "4",
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
                return Content(response.Content);
            }

            
        }

        [Route("contact/test")]
        public IActionResult Test(Code model)
        {
            Token token = new Token();
            List<ContactViewModel> listContacts = new List<ContactViewModel>();

            using (null)
            {
                var client = new RestClient("https://api.hubapi.com/oauth/v1/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded;charset=utf-8");
                request.AddParameter("grant_type", "authorization_code");
                request.AddParameter("client_id", "6b4a5dfe-0e33-4245-8dd9-7ff53b7b3764");
                request.AddParameter("client_secret", "1c071c63-e470-4eff-bd8b-aa9b3b3bb42a");
                request.AddParameter("redirect_uri", "https://lamwebapp.somee.com/Quote/Random");
                request.AddParameter("code", model.code);

                IRestResponse response = client.Execute(request);

                token = JsonConvert.DeserializeObject<Token>(response.Content);
            }

            AccessToken.access_token = token.access_token;

            using (null)
            {
                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts?limit=100&archived=false");
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
                IRestResponse response = client.Execute(request);

                JObject jsonResponse = JObject.Parse(response.Content);
                JArray arr = (JArray)jsonResponse["results"];
                listContacts = arr.ToObject<List<ContactViewModel>>();
            }

            return View(listContacts);
        }

        [Route("contact/HubIndex")]
        public IActionResult HubIndex()
        {
//            var result = GlobalData.Contacts;
//            return View(result);
            return Content("Null");
        }

        [Route("contact/detail")]
        public IActionResult Details(int id)
        {
            var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts/" + id + "?properties=firstname%2Clastname%2Cphone%2Cemail%2Chs_analytics_source%2Chs_analytics_source_data_1%2Chs_analytics_source_data_2%2Chs_analytics_first_url%2Chs_analytics_last_url%2Chs_analytics_first_referrer%2Chs_analytics_last_referrer%2Chs_analytics_average_page_views%2Crecent_conversion_event_name%2Crecent_conversion_date&archived=false");
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
            IRestResponse response = client.Execute(request);

            ContactViewModel contactViewModel = JsonConvert.DeserializeObject<ContactViewModel>(response.Content);
            return Content(contactViewModel.properties.hs_analytics_average_page_views);
            return View(contactViewModel);
        }

        [Route("contact/create")]
        public IActionResult Create()
        {
            ContactViewModel contactViewModel = new ContactViewModel();
            return View(contactViewModel);
        }

        [Route("contact/save")]
        public IActionResult Save(ContactViewModel contactViewModel)
        {
            contactViewModel.createdAt = DateTime.Today;
            contactViewModel.updatedAt = DateTime.Today;
            contactViewModel.archived = false;

            var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts");
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
            request.AddParameter("application/json", JsonConvert.SerializeObject(contactViewModel), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            ContactViewModel contact = JsonConvert.DeserializeObject<ContactViewModel>(response.Content);

//            var pos = _contactService.GetStaff();
//            var staff = GlobalData.Staffs.SingleOrDefault(x => x.Id == pos);
//            contact.staffOwnerId = staff.Id;
//            contact.staffOwnerName = staff.Name;

//            _contactService.Add(contact);

            return Content(response.Content);
        }

        [Route("contact/index")]
        public IActionResult Index()
        {
            List<ContactViewModel> listContacts = new List<ContactViewModel>();

            using (null)
            {
                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts?limit=100&archived=false");
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
                IRestResponse response = client.Execute(request);

                JObject jsonResponse = JObject.Parse(response.Content);
                JArray arr = (JArray)jsonResponse["results"];
                listContacts = arr.ToObject<List<ContactViewModel>>();
            }

            return View(listContacts);
        }

        [Route("contact/edit/{id}")]
        public IActionResult Edit(int id)
        {
            var contact = _contactService.GetContactByHubId(id.ToString());

            if (contact == null)
            {
                return Content("Không tìm thấy trong Database Akabiz");
            }
            return View(contact);
        }

        public IActionResult SaveEdit(ContactViewModel contactViewModel)
        {
            contactViewModel.updatedAt = DateTime.Today;
            contactViewModel.archived = false;

            var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts/" + contactViewModel.id);
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Bearer " + AccessToken.access_token);
            request.AddParameter("application/json", JsonConvert.SerializeObject(contactViewModel), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (_contactService.Edit(contactViewModel) != 0)
            {
                return Content("Không tìm thấy khách hàng");
            }
            
            return Content(response.Content);
        }

        [Route("contact/dividedata")]
        public IActionResult DivideData()
        {
            DivideViewModel divide = new DivideViewModel();

            divide.ListStaff = _staffService.GetSplitStaff().Select(x => new SelectListItem {Text = x.Name, Value = x.Id.ToString()}).ToList();
            return View(divide);
        }

        public IActionResult Divide(DivideViewModel div)
        {
            GlobalData.Pos = 0;
            var result = new List<int>();

            var str = "";

            foreach (var item in div.ListStaffId)
            {
                str += item + " - ";
            }

            if (!string.IsNullOrWhiteSpace(div.KeyWord))
            {
                result = _staffService.GetSplitStaff().Where(x => div.ListStaffId.Contains(x.Id) && (string.IsNullOrWhiteSpace(x.KeyWord) || x.KeyWord.Contains(div.KeyWord))).Select(x => x.Id).ToList();
            }
            else
            {
                result = _staffService.GetSplitStaff().Where(x => div.ListStaffId.Contains(x.Id)).Select(x => x.Id).ToList();
            }

            GlobalData.ChosenStaffs = result.ToList();
            return RedirectToAction("Index");
        }
    }
}
