using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieApp.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        //veritabaný baglama video 45
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MsSQLConnecttion")));
            //options.UseSqlite(Configuration.GetConnectionString("DefaultConnecttion"))); //sqlite bu
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                DataSeeding.Seed(app);
            }
            app.UseStaticFiles(); //wwroot kullanýma açar yani imageler gelir

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}"
             

               );

                //endpoints.MapControllerRoute(
                // name: "about",
                // pattern: "",
                // defaults: new { controller = "Home", action = "Index" }

                // );

                //endpoints.MapControllerRoute(
                //name: "home",
                //pattern: "about",
                //defaults: new { controller = "Home", action = "About" }

                //);

                //endpoints.MapControllerRoute(
                //    name:"movieList",
                //    pattern:"movies/list",
                //    defaults: new {controller="Movies",action="List"}

                //    );
                //endpoints.MapControllerRoute(
                //   name: "movieDetails",
                //   pattern: "movies/details",
                //   defaults: new { controller = "Movies", action = "Details" }

                //   );
            });
           
            
               
            
        }
    }
}
