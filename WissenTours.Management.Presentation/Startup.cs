using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WissenTours.Management.Application.Cities;
using WissenTours.Management.Application.Repositories;
using WissenTours.Management.DataAccess;

namespace WissenTours.Management.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        //DI Container => Dependency Injection Container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //City Interface'ini gordugun anda CityService 'in instance'ini al. Bunu Controller'da goruyo............ BURAAAA
            //Composit Root oldugu icin diger katmanlarýn referansýný almak zorunda 
            services.AddTransient<ICityService, CityService>();
            //Ne kadar Ýnjection yapýlan interface varsa hepsini bu metot'ta bildirmek zorundayýz.
            //Haliyle Presentation katmaný (Application ve DataAccess) katmanlarýný referans aldý.
            services.AddTransient<ICityRepository, CityRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
