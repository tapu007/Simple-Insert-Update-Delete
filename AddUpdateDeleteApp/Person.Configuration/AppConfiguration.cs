using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Person.BLL.Contract;
using Person.BLL.Manager;
using Person.DatabaseContext.DatabaseContext;
using Person.Repository.BaseRepository;
using Person.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Configuration
{
    public static class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<PersonDatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("PersonDatabaseContext")));

            services.AddTransient<IPersonageManager, PersonageManager>();
            services.AddTransient<IPersonageRepository, PersonageRepository>();



            services.AddMvc()

                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling =
                                               Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                }); ;


        }
    }
}
