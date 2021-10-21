using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailConfigEmailParner
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public int? Port { get; set; }
    }
}
