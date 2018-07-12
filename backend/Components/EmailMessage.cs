namespace CodeForGood.Components
{
    public class EmailMessage : IEmailMessage
    {
        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }
    }
}