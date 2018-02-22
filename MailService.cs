using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailClient
{
    public class MailService : IMailService
    {
        private readonly ISmtpConfig _smtpConfig;

        public MailService(ISmtpConfig smtpConfig)
        {
            _smtpConfig = smtpConfig;
        }

        public void SendMail(MailMessage mailMessage)
        {
            var client = _smtpConfig.GetSmtpClient();
            client.Send(mailMessage);
        }

    }
}