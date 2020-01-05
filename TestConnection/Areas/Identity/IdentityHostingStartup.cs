using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestConnection.Areas.Identity.Data;
using TestConnection.Data;

[assembly: HostingStartup(typeof(TestConnection.Areas.Identity.IdentityHostingStartup))]
namespace TestConnection.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TestConnectionContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TestConnectionContextConnection")));
                //services.AddDefaultIdentity<IdentityUser>()
                //.AddentityFrameworkStores<TestConnectionContext>();
            
            });
           
        }
    }
}