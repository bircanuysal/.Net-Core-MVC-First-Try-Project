using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreProje.Contexts;
using NetCoreProje.Entities;
using NetCoreProje.Interfaces;
using NetCoreProje.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje
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
            services.AddAuthentication();
            
            services.AddIdentity<AppUser, IdentityRole>(opt=>
            {
                opt.Password.RequireDigit = false; //say� olmak zorunda m�   
                opt.Password.RequireLowercase = false; //k���k harf gereklili�i olsun mu
                opt.Password.RequiredLength = 1; //uzunluk ,default=6
                opt.Password.RequireUppercase = false; //b�y�k harf zorunlulu�u
                opt.Password.RequireNonAlphanumeric = false; 
               
            }).AddEntityFrameworkStores<NetCoreProjeContexts>();
            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Home/GirisYap");
                opt.Cookie.Name = "NetCoreProje"; //bu cookie taray�ca da b�yle g�z�k�r
                opt.Cookie.HttpOnly = true; //js taraf�ndan ilgili cookie �ekilemez.
                opt.Cookie.SameSite = SameSiteMode.Strict; //lax = d�� kaynak kullanabilir. Strict=ilgili sayfa d���nda kullanamaz
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            });
            //services.AddIdentity<AppUser,IdentityRole>().AddEntityFrameworkStores<NetCoreProjeContexts>();
            services.AddScoped<IKategoriRepository, KategoriRepository>(); 
            services.AddScoped<IUrunRepository, UrunRepository>();
            services.AddScoped<IUrunKategoriRepository, UrunKategoriRepository>();
            services.AddDbContext<NetCoreProjeContexts>();
            services.AddSession();
            //services.AddSingleton(); //her iste�e tek bir nesne
            //services.AddTransient(); //her iste�e farkl� bir nesne
            //Service.Addscoped(); //ilgili iste�e tek bir nesne

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser>userManager,RoleManager<IdentityRole>roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            IdentityInitializer.OlusturAdmin(userManager, roleManager);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapControllerRoute(
                //    name: "BircanRoute",
                //    pattern:"Bircan",
                //    defaults: new {controller="Home" , action= "Index" });
                ////.com.tr/Bircan
                endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
