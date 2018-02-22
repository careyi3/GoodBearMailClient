using System.Net.Mail;

namespace MailClient
{
    public interface ISmtpConfig
    {
        SmtpClient GetSmtpClient();
    }
}