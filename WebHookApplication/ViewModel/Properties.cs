using System;

namespace WebHookApplication.ViewModel
{
    public class Properties
    {
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string company { get; set; }
        public string phone { get; set; }
        public string website { get; set; }

        public string hs_analytics_average_page_views { get; set; }
        public string hs_analytics_first_referrer { get; set; }
        public string hs_analytics_first_url { get; set; }
        public string hs_analytics_last_referrer { get; set; }
        public string hs_analytics_last_url { get; set; }
        public string hs_analytics_source { get; set; }
        public string hs_analytics_source_data_1 { get; set; }
        public string hs_analytics_source_data_2 { get; set; }
        public string hs_object_id { get; set; }
        public DateTime? recent_conversion_date { get; set; }
        public string recent_conversion_event_name { get; set; }
    }
}