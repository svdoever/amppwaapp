using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AmpPwaApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build().Run();
        }
    }
}
