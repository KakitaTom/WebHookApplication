using System;

namespace WebHookApplication.ViewModel
{
    public class ContactViewModel
    {
        public int id { get; set; }
        public Properties properties { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool archived { get; set; }

        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }

        public string KeyWordSplit { get; set; }
        public string Original_Sorce { get; set; }
        public string Original_Sorce_Drill_Down_1 { get; set; }
        public string Original_Sorce_Drill_Down_2 { get; set; }
        public string Last_Page_Seen { get; set; }
        public string First_Page_Seen { get; set; }
        public string Last_Referring_Site { get; set; }
        public string First_Referring_Site { get; set; }
        public string Averrage_Pageviews { get; set; }
        public int Number_Of_Form_Submissions { get; set; }
        public string Recen_Conversion { get; set; }
        public DateTime? Recen_Conversion_Data { get; set; }
        public string ContactHubSpotId { get; set; }
        public string Source { get; set; }



        public int staffOwnerId { get; set; }
        public string staffOwnerName { get; set; }
    }
}