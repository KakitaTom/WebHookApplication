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

        public int staffOwnerId { get; set; }
        public string staffOwnerName { get; set; }
    }
}