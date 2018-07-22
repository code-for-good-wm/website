using CodeForGood.Components;
using CodeForGood.Config;

using Cql.Core.AwsElasticBeanstalk;
using Cql.Core.Web;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Rewrite;
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
        ///     This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    // Customize URLS if needed
	                var conventions = options.Conventions;

	                conventions.AddPageRoute("/CodeOfConduct", "code-of-conduct");
	                conventions.AddPageRoute("/GRGiveCamp", "gr-give-camp");
	                conventions.AddPageRoute("/NonprofitAgencies", "nonprofit-agencies");
					conventions.AddPageRoute("/WeekendForGood", "weekend-for-good");
                });


            var operationResult = ElasticBeanstalkUtil.GetEnvironmentConfig();

            if (operationResult.Result == OperationResultType.Ok)
            {
                var configData = operationResult.Data;

                configData.TryGetValue("SES-AccessKeyId", out var accessKeyId);
                configData.TryGetValue("SES-SecretKey", out var secretKey);

                services.AddSingleton(new AwsConfig
                {
                    AccessKeyId = accessKeyId,
                    SecretKey = secretKey
                });

                services.AddSingleton<IEmailDispatcherService, AmazonSesEmailDispatcherService>();
            }
            else
            {
                services.AddSingleton<IEmailDispatcherService, NoOpEmailDispatcherService>();
            }

            services.AddRouting(options => { options.LowercaseUrls = true; });

            services.AddSingleton<IGoogleSettings, GoogleSettings>(e => Configuration.GetSection(nameof(GoogleSettings)).Get<GoogleSettings>());

            services.AddSingleton<ITagHelperComponent, GoogleTagComponent>();
        }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
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

            app.UseRewriter(new RewriteOptions()
                .AddRedirectToProxiedHttps()
                .AddRedirect("(.*)/$", "$1"));

            app.UseForwardedHeaders();
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseMvc(routes => { routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}"); });
        }
    }
}