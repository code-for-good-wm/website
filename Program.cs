using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CodeForGood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webApplication = WebHost
                .CreateDefaultBuilder(args)
                .UseSetting(WebHostDefaults.ApplicationKey, "code-for-good")
                .UseStartup<Startup>()
                .Build();

            webApplication.Run();
        }
    }
}
