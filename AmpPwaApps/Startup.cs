using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace AmpPwaApps
{
    public class Startup
    {
        public static IHostingEnvironment HostingEnvironment { get; set; }

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            this.Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json", false, true).AddJsonFile(string.Format("appsettings.{0}.json", (object)env.EnvironmentName), true).AddEnvironmentVariables().Build();
            Startup.HostingEnvironment = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole((IConfiguration)this.Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseCors(options => options.WithOrigins(new[] {
                "https://amppwaapps.azurewebsites.net",
                "https://amppwaapps-azurewebsites-net.cdn.ampproject.org",
                "https://amppwaapps.azurewebsites.net.amp.cloudflare.com",
                "https://cdn.ampproject.org",
                "http://localhost",
                "https://localhost"
            }).AllowAnyMethod()
            .AllowCredentials());

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseMvc((Action<IRouteBuilder>)(routes =>
            {
                routes.MapRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}");
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            }));
        }
    }
}