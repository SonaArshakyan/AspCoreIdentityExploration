using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using AspCoreIdentityExploration.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AspCoreIdentityExploration.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace AspCoreIdentityExploration
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
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContext<AspCoreIdentityExplorationContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:connectionString"]));
            services.AddIdentity<ApplicationUser,IdentityRole >(options => { options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireNonAlphanumeric = false;
            }) .AddEntityFrameworkStores<AspCoreIdentityExplorationContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddTransient<IEmailSender, Areas.Identity.EmailSender>();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
            services.AddAuthentication().AddGoogle(o =>
           {
               o.ClientId = "543084144715-5gp4a5094ir91upg5p1j3ltdjomk5513.apps.googleusercontent.com";
               o.ClientSecret = "A-r_qfOtWKJbGk0dLk-oRU0r";
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
