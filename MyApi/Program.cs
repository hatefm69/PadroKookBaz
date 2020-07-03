using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace MyApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Set deafult proxy
            WebRequest.DefaultWebProxy = new WebProxy("http://127.0.0.1:5120/", true) { UseDefaultCredentials = true };

            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("init main");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                //NLog: catch setup errors
                logger.Error(ex, "Stopped program because of exception");

                using (FileStream fs = File.Create("c:\\Temp\\errorStart.txt"))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(ex.Message);
                    fs.Write(title, 0, title.Length);
                }

                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
               WebHost.CreateDefaultBuilder(args)
                   .ConfigureLogging(options => options.ClearProviders())
                   .UseNLog()
               .UseIISIntegration()
                   .UseStartup<Startup>();
    }
}
