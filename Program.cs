using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CodeForGood
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
				.UseKestrel(c => c.AddServerHeader = false)
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();
		}
	}
}