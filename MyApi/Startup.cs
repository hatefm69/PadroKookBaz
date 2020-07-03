using System;
using Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebFramework.Configuration;
using WebFramework.CustomMapping;
using WebFramework.Middlewares;
using WebFramework.Swagger;
using Hangfire;
using WebFramework.Schedule;
using Hangfire.Dashboard;
using WebFramework.RabbitMQ;
using WebFramework.RealTime;
using WebFramework.Session;
using WebFramework.React;
using Microsoft.AspNetCore.Http;
using ElmahCore.Mvc;

namespace MyApi
{
    public class Startup
    {
        private readonly SiteSettings _siteSetting;
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            AutoMapperConfiguration.InitializeAutoMapper();

            _siteSetting = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            //services.AddResponseCaching();

            services.AddSession(
           //    z=> { z.Cookie.IsEssential = true;
           //    z.IdleTimeout = TimeSpan.FromMinutes(10);
           //}
           );
            //services.AddSession(z => {
            //    z.Cookie.IsEssential = true;
            //    z.IdleTimeout = TimeSpan.FromMinutes(10);
            //});
            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
            services.AddDbContext(Configuration);
            //services.AddScoped<GetInternetAddressAttribute>

            //services.AddCustomIdentity(_siteSetting.IdentitySettings);
            services.AddMinimalMvc();
            services.AddControllersWithViews();

            services.AddElmah(Configuration, _siteSetting);

            services.AddJwtAuthentication(_siteSetting.JwtSettings);

            services.AddCustomApiVersioning();

            services.AddSwagger();

            // services.AddSignalR();

            //services.AddHangFireService(Configuration);
            //services.AddRabbit(Configuration, _siteSetting.RabbitMQSettings);

            services.AddSessionService();
            services.AddReactPage();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                                .AllowAnyMethod();
                    ;
                });
            });

            //
            // here essential cookies should set true with site time out 
            //
            return services.BuildAutofacServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsProduction())
            //    app.UseResponseCaching();
            app.IntializeDatabase();

            if (env.IsDevelopment())
                app.UseCustomExceptionHandler();

            app.UseStaticFiles(new StaticFileOptions
            {
                //OnPrepareResponse = ctx =>
                //{
                //    const int durationInSeconds = 60 * 60 * 24*7;
                //    ctx.Context.Response.Headers[HeaderNames.CacheControl] =
                //        "public,max-age=" + durationInSeconds;

                //}
            });


            //app.UseHsts(env);

            // app.UseHangFire(_siteSetting.HangFirePath);

            // app.UseHangfireServer();

            app.UseElmah();

            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseSwaggerAndUI();

            //Add JWToken to all incoming HTTP Request Header
            app.UseSessionService();
            app.Use(async (context, next) =>
            {
                var JWToken = context.Session.GetString("JWToken");
                if (!string.IsNullOrEmpty(JWToken))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
                }
                await next();
            });


            app.UseAuthentication();
            //app.UseSignalR((x) =>
            //{
            //    x.MapHub<ChatHub>("/chatHub");
            //});


            //if (env.IsDevelopment())
            app.UseMvc((routes) =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

            });
            app.UseReactPage(env);
        }


    }
}
