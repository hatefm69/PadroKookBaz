using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.AspNetCore.Hosting;

namespace WebFramework.React
{
    public static class React
    {
        public static void AddReactPage(this IServiceCollection services)
        {
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

        }
        public static void UseReactPage(this IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
                //spa.UseReactDevelopmentServer(npmScript: "start");
            });
        }
    }
}
