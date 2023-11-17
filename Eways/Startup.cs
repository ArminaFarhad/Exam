using System;
using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection;
using Eways.Infrastructure;
using Eways.Repository;
using Eways.Repository.Context;
using Eways.Repository.IService;
using Eways.Services;
using Eways.Repository.IRepositories;
using Eways.Repository.Repositories;
using Microsoft.Extensions.Hosting.Internal;
//using Microsoft.Extensions.Hosting;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting.Internal;

namespace Eways
{
	public class Startup
	{
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<DbContext, AppDbContext>();

            //services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();

            services.AddRazorPages().AddRazorPagesOptions(options => {
                options.RootDirectory = "/UserModel";
            });



        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseSwagger();
            //
            //app.UseSwaggerUI(options =>
            //{
            //    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            //    options.RoutePrefix = string.Empty;
            //});

            //app.MapRazorPages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

        }
    }
}

