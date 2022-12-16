using EmployeeManagmentSystem.Services;
using EmployeeManagmentSystem.Services.Interfaces;
using EmployeeManagmentSystem.Repositories;
using EmployeeManagmentSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagmentSystem.Repositories.DatabaseContexts;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Repositories;

namespace EmployeeManagmentSystem
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
            services.AddDbContext<EmsContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EmsDatabase"));
                options.UseLazyLoadingProxies(true);
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            //Dependency Injections
            services.AddScoped<IEmployeeService,EmployeeService>();
            services.AddScoped<IEmployeeRepository,EmployeeRepository>();

            //This code used for add cors helps to resolve cross-origin error 
            services.AddCors(cors => cors.AddPolicy("MyPolicy", builder => {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
        }
    
        

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
