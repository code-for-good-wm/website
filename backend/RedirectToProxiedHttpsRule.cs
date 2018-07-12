using System;

using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;

namespace CodeForGood
{
	public class RedirectToProxiedHttpsRule : IRule
	{
		public virtual void ApplyRule(RewriteContext context)
		{
			var request = context.HttpContext.Request;

			var scheme = GetRequestScheme(request);

			if (scheme != "https")
			{
				var uri = new UriBuilder(request.GetUri())
				{
					Scheme = Uri.UriSchemeHttps
				};

				context.HttpContext.Response.Redirect(uri.ToString(), true);
			}
		}

		private static string GetRequestScheme(HttpRequest request)
		{
			if (request.Headers.ContainsKey("X-Forwarded-Proto"))
			{
				return request.Headers["X-Forwarded-Proto"][0];
			}

			return request.IsHttps ? "https" : "http";
		}
	}
}