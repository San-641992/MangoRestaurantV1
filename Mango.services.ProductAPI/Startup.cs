using Mango.services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System;

namespace Mango.services.ProductAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("MyConnectionString")));

            // Add other services here
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the app here
        }
    }
   
}
