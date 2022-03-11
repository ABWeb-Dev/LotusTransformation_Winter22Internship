using LotusTransformation.Data;
using LotusTransformation.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LotusTransformation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration; ;
        }

        private IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ClientSignUpVM>();
            services.AddMvcCore().AddRazorRuntimeCompilation();
            services.AddDbContext<LotusTransformationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LotusTransformationDb")));



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseStatusCodePages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=LotusGeneral}/{action=Home}");
            });
        }
    }
}
