using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Cql.Core.Web;

namespace CodeForGood.Components
{
    public class NoOpEmailDispatcherService : IEmailDispatcherService
    {
        public Task<OperationResult> SendEmail(IEmailMessage emailMessage)
        {
	        Debug.WriteLine(emailMessage.To.ToString());
			Debug.WriteLine(emailMessage.Body);

            return Task.FromResult(OperationResult.Ok());
        }
    }
}