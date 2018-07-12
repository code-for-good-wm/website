using System.Threading.Tasks;

using Cql.Core.Web;

namespace CodeForGood.Components
{
    public class NoOpEmailDispatcherService : IEmailDispatcherService
    {
        public Task<OperationResult> SendEmail(IEmailMessage emailMessage)
        {
            return Task.FromResult(OperationResult.Ok());
        }
    }
}