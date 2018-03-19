using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using React.AspNet;

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
            services.AddReact();
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
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Initialise ReactJS.NET. Must be before static files.
            app.UseReact(config =>
            {
                // If you want to use server-side rendering of React components,
                // add all the necessary JavaScript files here. This includes
                // your components as well as all of their dependencies.
                // See http://reactjs.net/ for more information. Example:
                //config
                //  .AddScript("~/Scripts/First.jsx")
                //  .AddScript("~/Scripts/Second.jsx");
                config.AddScript("/js/tutorial.jsx");
                // If you use an external build too (for example, Babel, Webpack,
                // Browserify or Gulp), you can improve performance by disabling
                // ReactJS.NET's version of Babel and loading the pre-transpiled
                // scripts. Example:
                //config
                //config.SetLoadBabel(false);
                //config.AddScriptWithoutTransform("~/Scripts/bundle.server.js");
            });

            app.UseCors(options => options.WithOrigins(new[] {
                "https://amppwaapps.azurewebsites.net",
                "https://amppwaapps-azurewebsites-net.cdn.ampproject.org",
                "https://amppwaapps.azurewebsites.net.amp.cloudflare.com",
                "https://cdn.ampproject.org"
            }).AllowAnyMethod()
            .AllowCredentials());

            app.UseStaticFiles();
            app.UseMvc((Action<IRouteBuilder>)(routes =>
            {
                routes.MapRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}");
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            }));
        }
    }
}