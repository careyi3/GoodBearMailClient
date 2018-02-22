using System.Net.Mail;
using System.Threading.Tasks;

namespace GoodBearMailClient
{
    public interface IMailService
    {
        void SendMail(MailMessage mailMessage);
    }
}