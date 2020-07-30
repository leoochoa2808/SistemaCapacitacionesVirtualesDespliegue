using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

                //Conexion a base de datos
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<KleerDbContext>(o =>
                    o.UseNpgsql(
<<<<<<< HEAD
                    // "Host=ec2-54-234-28-165.compute-1.amazonaws.com;" +
                    // "Database=d36smukblul4sn;Username=mudcwplykcnyxd;"+
                    // "Password=3acf5700563f773a4848eeb9d479b2e3ada82b3ca18edb694f08a714a7e33e83;"+
                    // "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                    
                    // CONEXIÓN JOSÉ
                    "Host=ec2-54-234-28-165.compute-1.amazonaws.com;" +
                    "Database=dem3lid08fd3uv;Username=jkyeoqoduaxgmw;"+
                    "Password=550c535ff443076255991dcbffa2258ccb19b497ab4f31ea397ff9af9b6c3ff1;"+
                    "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                    
/*   CONEXION LEONARDO    
                "Host=ec2-52-202-146-43.compute-1.amazonaws.com;" +
=======
                        "Host=ec2-54-234-28-165.compute-1.amazonaws.com;" +
                        "Database=dem3lid08fd3uv;Username=jkyeoqoduaxgmw;"+
                        "Password=550c535ff443076255991dcbffa2258ccb19b497ab4f31ea397ff9af9b6c3ff1;"+
                        "Port=5432;SSL Mode=Require;Trust Server Certificate=true"
                    )
                    
                    // CONEXIÓN JOSÉ
                    /* "Host=ec2-54-234-28-165.compute-1.amazonaws.com;" +
                    "Database=dem3lid08fd3uv;Username=jkyeoqoduaxgmw;"+
                    "Password=550c535ff443076255991dcbffa2258ccb19b497ab4f31ea397ff9af9b6c3ff1;"+
                    "Port=5432;SSL Mode=Require;Trust Server Certificate=true" */

                    /* "Host=ec2-54-234-28-165.compute-1.amazonaws.com;" +
                    "Database=d36smukblul4sn;Username=mudcwplykcnyxd;"+
                    "Password=3acf5700563f773a4848eeb9d479b2e3ada82b3ca18edb694f08a714a7e33e83;"+
                    "Port=5432;SSL Mode=Require;Trust Server Certificate=true" */
                    
                    /*   CONEXION LEONARDO    
                    "Host=ec2-52-202-146-43.compute-1.amazonaws.com;" +
>>>>>>> rama_jose
                    "Database=dec175u6j2l7ep;Username=uzymstzjwswvba;"+
                    "Password=4855b2563de5e64b7726b9c7b13b81aafdc7055f68e5b10940b676fcbe81b4bf;"+
                    "Port=5432;SSL Mode=Require;Trust Server Certificate=true") */
            );
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
