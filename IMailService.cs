using System.Net.Mail;
using System.Threading.Tasks;

namespace MailClient
{
    public interface IMailService
    {
        void SendMail(MailMessage mailMessage);
    }
}