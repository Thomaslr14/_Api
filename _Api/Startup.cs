using System;
using System.IO;
using System.Reflection;
using _Api.Controllers;
using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Interfaces.BaseInterfaces;
using _Api.Interfaces.MappingInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Maps;
using _Api.MVC.Controllers;
using _Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace _Api
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
            services.AddScoped<IBaseController,BaseController>();
            services.AddScoped<IMongoConnect,MongoDBConnect>();
            services.AddScoped<IRepositoryInfectado,RepositoryInfectado>();
            services.AddScoped<IRepositoryVacinado,RepositoryVacinado>();
            services.AddScoped<IMapGeoLocationInfectado, MapGeoLocationInfectado>();
            services.AddControllersWithViews();

            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo 
            //     { 
            //         Title = "_Api",
            //         Version = "v1",
            //         Description = "Projeto de API que visa contabilizar infectados e vacinados da Covid-19",
            //         Contact = new OpenApiContact
            //         {
            //             Name = "Thomas Rodrigues",
            //             Email = string.Empty,
            //             Url = new Uri("https://github.com/Thomaslr14"),
            //         }
            //     });
            //     var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //     var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //     c.IncludeXmlComments(xmlPath);
            // });
        
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            // app.UseSwagger(c =>
            // {
            //     c.SerializeAsV2 = true;
            // });
            // app.UseSwaggerUI(c =>
            // {
            //     c.SwaggerEndpoint("/swagger/v1/swagger.json", "_Api");
            //     c.RoutePrefix = string.Empty;
            // });
            app.UseHttpsRedirection();
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
