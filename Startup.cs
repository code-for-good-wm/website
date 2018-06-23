using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForGood.Components;
using CodeForGood.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddRazorPagesOptions(options => {
                    // Customize URLS if needed
                    //options.Conventions.AddPageRoute("/codeofconduct", "code-of-conduct");
                });

            services.AddRouting(options => {
                options.LowercaseUrls = true;
            });

            services.AddSingleton<IGoogleSettings, GoogleSettings>(e => Configuration.GetSection(nameof(GoogleSettings)).Get<GoogleSettings>());
            services.AddSingleton<ITagHelperComponent, GoogleTagComponent>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
