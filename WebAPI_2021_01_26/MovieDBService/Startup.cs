using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MovieDBService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDBService
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
            //halloLiebeTeilnehmerAlleErstenBuchstabenEinesWortesWerdenGroßGeschrieben
            //strVorname strNachname
            //services.AddControllers();
            //.AddXmlSerializerFormatters();

            //https://docs.microsoft.com/de-de/aspnet/core/web-api/advanced/formatting?view=aspnetcore-5.0
            services.AddControllers(options =>
            {
                options.RespectBrowserAcceptHeader = true; // false by default
                options.ReturnHttpNotAcceptable = true; // 406 Status Fehler wird zurück geliefert, wenn bei der Requestanfrage das Format nicht unterstützt wird. 
            }).AddXmlSerializerFormatters();


            services.AddControllers().AddJsonOptions(options =>
            {
                // Use the default property (Pascal) casing.
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                //options.JsonSerializerOptions.MaxDepth = 

                // Configure a custom converter.
                //options.JsonSerializerOptions.Converters.Add(new MyCustomJsonConverter());
            });








            services.AddDbContext<MovieDBContext>(opt =>
            {
                opt.UseInMemoryDatabase("MovieDb");
            });
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieDBService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieDBService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
