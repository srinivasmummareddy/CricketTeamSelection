using Contracts;
using Core;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Npgsql;
using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace Api
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
            string connectionString = Configuration.GetConnectionString("Default");
            services.AddScoped<IDbConnection>(e => new NpgsqlConnection(connectionString));

            services.AddTransient<IPlayersRepository, PlayersRepository>();
            services.AddTransient<ISelectedTeamValidationService, SelectedTeamValidationService>();
            services.AddTransient<ITeamEnricherService, TeamEnricherService>();
            services.AddTransient<ITeamSelectionService, TeamSelectionService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "CricketTeamSelection", 
                    Version = "v1",
                    Description = "This API selects cricket team according to selection criteria",
                    Contact = new OpenApiContact
                    {
                        Name = "Srinivas Mummareddy",
                        Email = "srinivasmummareddy@yahoo.com",
                        Url = new Uri("https://www.linkedin.com/in/srinivas-mummareddy/"),
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseExceptionHandler("/Error");

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CricketTeamSelection v1"));

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
