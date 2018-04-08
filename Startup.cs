using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SimpleBankSystem.Models;
using SimpleBankSystem.Models.Repository;
using SimpleBankSystem.Models.Repository.FakeRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Simple_Bank_System
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration config) => Configuration = config;
        public void ConfigureServices(IServiceCollection services)
        {
           // Application Db Context
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseMySql(Configuration["Data:SimpleBankSystemDb:ConnectionString"])
                );


            // Inject the dependencies
            services.AddTransient<IUserRepository, FakeUserRepository>();
            services.AddTransient<IBankAccountRepository, FakeBankAccountRepository>();

            // Adding UserIdentity service
            services.AddIdentity<AppIdentityUser, AppIdentityRole>()
                        .AddEntityFrameworkStores<ApplicationDbContext>()
                        .AddDefaultTokenProviders();

            // Adding basic mvc architecture classes
            services.AddMvc();
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {   
            // Enabling Error Details pages => Triggered in exceptions
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            // Enabling access to wwwroot/ files 
            app.UseStaticFiles(); 

            // Applying Default Mvc Route Controller = Home, Action = Index
            app.UseMvc( 
                routes => {
                    routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}",
                    defaults: new { controller = "BankAccount", action = "Index" });
                }
            );

        }
    }
}
