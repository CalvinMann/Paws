using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using PetDesk.Paws.Infrastructure.WebSockets.SignalR;
using System.IO;
using Microsoft.EntityFrameworkCore;
using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.UseCases.GetAppointments;
using PetDesk.Paws.Infrastructure.Repositories.EntityFramework;
using PetDesk.Paws.Application.UseCases.RequestAppointment;
using PetDesk.Paws.Application.UseCases.RegisterClient;
using PetDesk.Paws.Infrastructure.Repositories.InMemory;
using PetDesk.Paws.Application.UseCases.RegisterPatient;

namespace PetDesk.Paws.WebApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc();

           services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();

                //options.IncludeXmlComments(
                //   Path.ChangeExtension(
                //       typeof(Startup).Assembly.Location,
                //       "xml"));

                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = Configuration["App:Title"],
                    Version = Configuration["App:Version"],
                    Description = Configuration["App:Description"],
                    TermsOfService = Configuration["App:TermsOfService"]
                });

                options.CustomSchemaIds(x => x.FullName);
            });

            services.AddAutoMapper();

            services.AddSignalR(); 

            // register the DbContext on the container, getting the connection string from
            var connectionString = Configuration["ConnectionStrings:PawsDBConnectionString"];
            services.AddDbContext<PawsDbContext>(o => o.UseSqlServer(connectionString));

            //Application
           
            services.AddScoped<IRegisterClient, RegisterClient>();
            services.AddScoped<IRegisterPatient, RegisterPatient>();
            services.AddScoped<IRequestAppointment, RequestAppointment>();
            services.AddScoped<IGetAppointments, GetAppointments>();
            services.AddScoped<IRequestAppointment, RequestAppointment>();

            //Infrastructure
            services.AddScoped<IAppointmentReadOnlyRepository, Infrastructure.Repositories.InMemory.AppointmentsRepository>();
            services.AddScoped<IAppointmentWriteOnlyRepository, Infrastructure.Repositories.InMemory.AppointmentsRepository>();

            services.AddScoped<IClientReadOnlyRepository, Infrastructure.Repositories.InMemory.ClientsRepository>();
            services.AddScoped<IClientWriteOnlyRepository, Infrastructure.Repositories.InMemory.ClientsRepository>();

            services.AddScoped<IPatientReadOnlyRepository, Infrastructure.Repositories.InMemory.PatientsRepository>();
            services.AddScoped<IPatientWriteOnlyRepository, Infrastructure.Repositories.InMemory.PatientsRepository>();


            services.AddSingleton(typeof(Context)); //InMemoryContext


            ////// Auto Mapper Configurations
            ////var mappingConfig = new MapperConfiguration(mc =>
            ////{
            ////    mc.AddProfile(new MappingProfile());
            ////});

            ////IMapper mapper = mappingConfig.CreateMapper();
            ////services.AddSingleton(mapper);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");

            app.UseMvc();

            app.UseSwagger()
               .UseSwaggerUI(c =>
               {
                   c.SwaggerEndpoint("/swagger/v1/swagger.json", "PAWS API v1");
               });


            app.UseSignalR(routes => routes.MapHub<AppointmentHub>("/appointmenthub"));
        }
    }
}
