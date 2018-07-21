using System;

using System.Net.Mail;

namespace CodeForGood.Components
{
    public class EmailMessage : IEmailMessage
    {
        public MailAddress To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }
    }
}