using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBearMailClient
{
    public interface ISmtpSettings
    {
        int Port { get; set; }
        string Host { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        bool EnableSsl { get; set; }
    }
}
