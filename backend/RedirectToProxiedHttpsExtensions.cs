using Microsoft.AspNetCore.Rewrite;

namespace CodeForGood
{
	public static class RedirectToProxiedHttpsExtensions
	{
		public static RewriteOptions AddRedirectToProxiedHttps(this RewriteOptions options)
		{
			options.Rules.Add(new RedirectToProxiedHttpsRule());
			return options;
		}
	}
}