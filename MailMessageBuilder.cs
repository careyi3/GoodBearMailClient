using System.Collections.Generic;
using System.Net.Mail;

namespace MailClient
{
    public class MailMessageBuilder : IMailMessageBuilder
    {
        public MailMessage BuildMessage(MailAddress from, ICollection<MailAddress> to, string subject, string body, bool isHtml)
        {
            var message = new MailMessage();
            message.From = from;
            foreach (var recipent in to)
            {
                message.To.Add(recipent);
            }
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = isHtml;

            return message;
        }

        public MailMessage BuildMessageWithAttachments(MailAddress from, ICollection<MailAddress> to, string subject, string body, bool isHtml,ICollection<Attachment> attachments)
        {
            var message = new MailMessage();
            message.From = from;
            foreach (var recipent in to)
            {
                message.To.Add(recipent);
            }
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = isHtml;
            foreach(var attachment in attachments)
            {
                message.Attachments.Add(attachment);
            }

            return message;
        }
    }
}