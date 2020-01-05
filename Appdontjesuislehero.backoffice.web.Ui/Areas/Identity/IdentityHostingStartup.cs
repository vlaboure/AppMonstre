using System;
using Appdontjesuislehero.backoffice.web.Ui.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Appdontjesuislehero.backoffice.web.Ui.Areas.Identity.IdentityHostingStartup))]
namespace Appdontjesuislehero.backoffice.web.Ui.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppdontjesuisleherobackofficewebUiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppdontjesuisleherobackofficewebUiContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AppdontjesuisleherobackofficewebUiContext>();
            });
        }          
    }
}