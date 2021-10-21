using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoAccount
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MacAdress { get; set; }
        public DateTime? DateExpiration { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? IsActive { get; set; }
        public int? MaxThreed { get; set; }
        public int? TimeStopErrorZalo { get; set; }
        public int? TimeStopErrorFacebook { get; set; }
        public int? TimeStopErrorShopee { get; set; }
        public int? TimeSleepByStepZalo { get; set; }
        public int? TimeSleepByStepFacebook { get; set; }
        public TimeSpan? TimeInDayRunFacebookFrom { get; set; }
        public TimeSpan? TimeInDayRunFacebookTo { get; set; }
        public int? CountAnUnknownError { get; set; }
    }
}
