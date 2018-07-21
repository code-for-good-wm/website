using System.Net.Mail;

namespace CodeForGood.Components
{
    public interface IEmailMessage
    {
        MailAddress To { get; set; }

        string Subject { get; set; }

        string Body { get; set; }

        bool IsBodyHtml { get; set; }
    }
}