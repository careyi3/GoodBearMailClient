using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GoodBearMailClient
{
    public interface IMailMessageBuilder
    {
        MailMessage BuildMessage(MailAddress from, ICollection<MailAddress> to, string subject, string body, bool isHtml);
        MailMessage BuildMessageWithAttachments(MailAddress from, ICollection<MailAddress> to, string subject, string body, bool isHtml, ICollection<Attachment> attachments);
    }
}
