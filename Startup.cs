using CodeForGood.Components;
using CodeForGood.Config;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeForGood
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		/// <summary>
		/// This method gets called by the runtime. Use this method to add services to the container. 
		/// </summary>
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc()
				.AddRazorPagesOptions(options =>
				{
					// Customize URLS if needed
					//options.Conventions.AddPageRoute("/codeofconduct", "code-of-conduct");
				});

			services.AddRouting(options => { options.LowercaseUrls = true; });

			services.AddResponseCompression(options =>
			{
				options.Providers.Add<BrotliCompressionProvider>();
				options.Providers.Add<GzipCompressionProvider>();

				options.EnableForHttps = true;
			});

			services.AddSingleton<IGoogleSettings, GoogleSettings>(e => Configuration.GetSection(nameof(GoogleSettings)).Get<GoogleSettings>());

			services.AddSingleton<ITagHelperComponent, GoogleTagComponent>();
		}

		/// <summary>
		/// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="env"></param>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseStaticFiles();
			app.UseHttpsRedirection();
			app.UseResponseCompression();
			app.UseMvc();
		}
	}
}