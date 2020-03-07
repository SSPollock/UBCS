using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreConcepts.Pages.Models;
using CoreConcepts.Pages.Services;
using CoreConcepts.Pages.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreConcepts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            string connString = ConfigurationExtensions.GetConnectionString(
                this.Configuration, "ComplexDb2");
            ConnectionStringHelper.ConnectionString = connString;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IStocks, StockPrices>();
            services.AddRazorPages();
            services.AddRazorPages().AddRazorOptions(options => 
            { 
                options.PageViewLocationFormats.Add("/Pages/MyPartials/{0}.cshtml"); 
            });
            services.Configure<EmailSettingsOptions>(Configuration); 
            services.Configure<CompanyOptions>(Configuration);
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
