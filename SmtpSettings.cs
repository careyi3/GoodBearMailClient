using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
    public class SmtpSettings : ISmtpSettings
    {
        public int Port { get; set; }

        public string Host { get; set; }

        public string Username { get; set;}

        public string Password { get; set; }

        public bool EnableSsl { get; set; }

    }
}
