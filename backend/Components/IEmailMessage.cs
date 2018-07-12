namespace CodeForGood.Components
{
    public interface IEmailMessage
    {
        string To { get; set; }

        string Subject { get; set; }

        string Body { get; set; }

        bool IsBodyHtml { get; set; }
    }
}