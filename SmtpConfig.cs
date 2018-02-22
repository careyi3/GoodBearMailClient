using System.Net;
using System.Net.Mail;

namespace MailClient
{
    public class SmtpConfig : ISmtpConfig
    {
        private readonly bool _enabledSsl;
        private readonly string _host;
        private readonly string _password;
        private readonly int _port;

        private readonly ISmtpSettingsService _smtpSettingsService;
        private readonly string _username;

        public SmtpConfig(ISmtpSettingsService settingsService)
        {
            _smtpSettingsService = settingsService;
        }

        public SmtpConfig(int port, string host, string username, string password, bool enableSsl)
        {
            _port = port;
            _host = host;
            _username = username;
            _password = password;
            _enabledSsl = enableSsl;
        }

        public SmtpClient GetSmtpClient()
        {
            if (_smtpSettingsService != null)
            {
                var settings = _smtpSettingsService.SmtpSettingsConfig;
                var smtpClient = new SmtpClient();
                smtpClient.Port = settings.Port;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = settings.Host;
                smtpClient.EnableSsl = settings.EnableSsl;
                smtpClient.Credentials = new NetworkCredential(settings.Username, settings.Password);

                return smtpClient;
            }
            else
            {
                var smtpClient = new SmtpClient();
                smtpClient.Port = _port;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = _host;
                smtpClient.EnableSsl = _enabledSsl;
                smtpClient.Credentials = new NetworkCredential(_username, _password);

                return smtpClient;
            }
        }
    }
}