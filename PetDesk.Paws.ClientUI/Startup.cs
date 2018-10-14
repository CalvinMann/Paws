﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PetDesk.Paws.ClientUI
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


            //Im using the FeatureFolder project set up from OdeToCode. 
            //This is an excellent way to layout the project into clear and consise use cases
            //This is one clean architecture principal - the folder structure should be clear on what it does
            services
                .AddMvc()
                .AddFeatureFolders(new OdeToCode.AddFeatureFolders.FeatureFolderOptions()
                { FeatureFolderName = "UseCases" });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddSignalR(); //Adds the SignalR 

            //// register the DbContext on the container, getting the connection string from
            //var connectionString = Configuration["ConnectionStrings:PawsDBConnectionString"];
            //services.AddDbContext<PawsDbContext>(o => o.UseSqlServer(connectionString));


            ////Infrastructure
            //services.AddScoped<IAppointmentReadOnlyRepository, AppointmentsRepository>();
            //services.AddScoped<IAppointmentWriteOnlyRepository, AppointmentsRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}");
            });

            //app.UseSignalR(routes => routes.MapHub<AppointmentHub>("/appointmenthub"));
        }
    }
}
