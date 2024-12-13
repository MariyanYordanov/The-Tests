﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheTests.Infrastructure.Data;
using TheTests.Infrastructure.Data.Models;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            //services.AddScoped<IRepository, Repository>();
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            // false must be true in production
            services
                .AddDefaultIdentity<AppUser>(identityOptions =>
                {
                    identityOptions.Lockout = new LockoutOptions
                    {
                        DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30),
                        MaxFailedAccessAttempts = 20
                    };

                    identityOptions.Password = new PasswordOptions
                    {
                        RequireDigit = false,
                        RequireLowercase = false,
                        RequireNonAlphanumeric = false,
                        RequireUppercase = false,
                        RequiredLength = 6
                    };
                    //options.SignIn.RequireConfirmedAccount = false;
                    identityOptions.SignIn = new SignInOptions
                    {
                        RequireConfirmedAccount = false,
                        RequireConfirmedEmail = false
                    };

                    identityOptions.User = new UserOptions
                    {
                        AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.@1234567890!#$%&*+-/=?^_{|}~",
                        RequireUniqueEmail = true
                    };
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication().AddCookie(options =>
            {
                options.AccessDeniedPath = "My Error Page";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrator", policy =>
                {
                    policy.RequireRole("Administrator");
                });
            });

            return services;
        }
    }
}
