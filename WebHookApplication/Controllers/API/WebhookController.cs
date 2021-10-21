using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHookApplication.Service;

namespace WebHookApplication.Controllers.API
{
    [Route("api/webhook")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        //        private readonly string _appId = "236745";
        //        private readonly string _clientId = "6b4a5dfe-0e33-4245-8dd9-7ff53b7b3764";
        //        private readonly string _clientSecret = "1c071c63-e470-4eff-bd8b-aa9b3b3bb42a";

//        [HttpPost("verifypush")]
//        public IActionResult VerifyPush()
//        {
//
//            //            Request.Headers.Add("X-HubSpot-Signature-Version", "v1");
//
//            string documentContents;
//
//            using (Stream receiveStream = Request.Body)
//            {
//                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
//                {
//                    documentContents = readStream.ReadToEnd();
//                }
//            }
//
//            var hubSpotService = new HubspotService();
//            hubSpotService.VerifyPush(documentContents);
//            return Ok(documentContents);
//        }
//
//        [HttpGet("getall")]
//        public IActionResult GetAll()
//        {
//            var wh = new WebhookService();
//            var list = wh.GetALL();
//
//            return Ok(list);
//        }
    }
}
