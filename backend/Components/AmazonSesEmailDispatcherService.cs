using System;
using System.Net.Mail;
using System.Threading.Tasks;

using Amazon;
using Amazon.Ses;

using CodeForGood.Config;

using Cql.Core.Web;

namespace CodeForGood.Components
{
    public class AmazonSesEmailDispatcherService : IEmailDispatcherService
    {
        private readonly AwsConfig _awsConfig;

        public AmazonSesEmailDispatcherService(AwsConfig awsConfig)
        {
            _awsConfig = awsConfig;
        }

        public async Task<OperationResult> SendEmail(IEmailMessage emailMessage)
        {
            try
            {
                var msg = new MailMessage
                {
                    From = new MailAddress("contact-us@codeforgoodwm.org", "Website Contact Form"),
                    Subject = emailMessage.Subject,
                    Body = emailMessage.Body,
                    IsBodyHtml = emailMessage.IsBodyHtml,
                    To =
                    {
                        emailMessage.To
                    }
                };

                var awsCredential = new AwsCredential(_awsConfig.AccessKeyId, _awsConfig.SecretKey);

                using (var client = new SesClient(AwsRegion.USEast1, awsCredential))
                {
                    var sendEmailResult = await client.SendEmailAsync(msg);

                    return OperationResult.Ok(sendEmailResult);
                }
            }
            catch (Exception ex)
            {
                return OperationResult.Error(ex);
            }
        }
    }
}