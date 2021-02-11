using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SalesInMove.Services;

namespace SalesInMove
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    
                    ValidIssuer = "https://localhost:5001",
                    ValidAudience = "https://localhost:5001",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                };
            });

            services.AddControllersWithViews();
            services.AddDbContext<SalesmenDbContext>(opt =>
            {
                opt.UseNpgsql(Configuration.GetConnectionString("SalesmenConnection"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>(config =>
            {
                config.Password.RequiredLength = 4;
                config.SignIn.RequireConfirmedAccount = false;
                config.Password.RequireDigit = false;
                config.Password.RequireUppercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.SignIn.RequireConfirmedEmail = true;

            })
                .AddEntityFrameworkStores<SalesmenDbContext>()
                .AddDefaultTokenProviders();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            services.AddAuthentication().AddGoogle(options =>
            {
            IConfigurationSection googleAuthNSection =
                Configuration.GetSection("Authentication:Google");

            options.ClientId = googleAuthNSection["ClientId"];
            options.ClientSecret = googleAuthNSection["ClientSecret"];
            });

            //var mailKitOptions = Configuration.GetSection("Email").Get<MailKitOptions>();
            //services.AddMailKit(Configuration => Configuration.UseMailKit(mailKitOptions));
            services.AddTransient<SmtpClient>((serviceProvider) =>
            {
                var config = serviceProvider.GetRequiredService<IConfiguration>();
                return new SmtpClient()
                {
                    EnableSsl = true,
                    Host = config.GetValue<String>("Email:Smtp:Host"),
                    Port = config.GetValue<int>("Email:Smtp:Port"),
                    Credentials = new NetworkCredential(config.GetValue<String>("Email:Smtp:Username"), config.GetValue<String>("Email:Smtp:Password"))
                };
           });

           services.AddScoped<ICompanyRepository, SQLCompanyRepositoryAsync>();
           services.AddScoped<IEmployeeFactory, EmployeeFactory>();
           services.AddScoped<ISalesmenRepository, SQLSalesmenRepository>();

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
            app.UseSpaStaticFiles();

            app.UseRouting();
            
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
