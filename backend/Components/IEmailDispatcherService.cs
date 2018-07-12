using System.Threading.Tasks;

using Cql.Core.Web;

namespace CodeForGood.Components
{
    public interface IEmailDispatcherService
    {
        Task<OperationResult> SendEmail(IEmailMessage emailMessage);
    }
}