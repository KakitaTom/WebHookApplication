using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AkaBizSmtp
    {
        public string Email { get; set; }
        public string ServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public bool? EnableSsl { get; set; }
    }
}
