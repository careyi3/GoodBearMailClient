using System.Net.Mail;

namespace GoodBearMailClient
{
    public interface ISmtpConfig
    {
        SmtpClient GetSmtpClient();
    }
}