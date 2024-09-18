using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcdemo.Data;
using mvcdemo.Models.ModelBinding;

namespace mvcdemo
{
    public class Startup
    {
        private IServiceCollection services;
        private IConfiguration configuration;
        public Startup(IServiceCollection services,  IConfiguration configuration)
        {
            this.services = services;
            this.configuration = configuration;
        }

        public void ConfigureServices()
        {
            services.AddControllersWithViews(options=>
                options.ModelBinderProviders.Insert(0, new ModelBinderProvider())
            );

            services.AddDbContext<VCBDataContext>(
                options=>options.UseSqlServer(
                    configuration.GetConnectionString("VCBDataContext"))
            );
        }

        public void ConfigureMiddleware(WebApplication app, IHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
        }

        public void ConfigureRouting(WebApplication app)
        {
             app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        }
    }
}