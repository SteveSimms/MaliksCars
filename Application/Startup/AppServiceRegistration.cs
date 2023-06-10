﻿using BlazorSpark.Library.Auth;
using BlazorSpark.Library.Database;
using BlazorSpark.Library.Logging;
using BlazorSpark.Library.Mail;
using Coravel;
using MaliksCars.Application.Database;
using MaliksCars.Application.Events.Listeners;
using MaliksCars.Application.Models;
using MaliksCars.Application.Services;
using MaliksCars.Application.Services.Auth;
using MaliksCars.Application.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace MaliksCars.Application.Startup
{
    public static class AppServiceRegistration
    {
        public static IServiceCollection
        AddAppServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddCustomServices();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDatabase<ApplicationDbContext> (config);
            services.AddLogger (config);
            services
                .AddAuthorization(config,
                new string[] { CustomRoles.Admin, CustomRoles.User });
            services.AddAuthentication<ICookieService> (config);
            services.AddTaskServices();
            services.AddScheduler();
            services.AddQueue();
            services.AddEventServices();
            services.AddEvents();
            services.AddMailer (config);
            return services;
        }

        private static IServiceCollection
        AddCustomServices(this IServiceCollection services)
        {
            // add custom services
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<UsersService>();
            services.AddScoped<RolesService>();
            services.AddScoped<IExampleService, ExampleService>();
            services.AddScoped<ICookieService, CookieService>();
            services
                .AddScoped
                <AuthenticationStateProvider, SparkAuthenticationStateProvider>(
                );
            services.AddScoped<ICarService, CarService>();
            return services;
        }

        private static IServiceCollection
        AddEventServices(this IServiceCollection services)
        {
            // add custom events here
            services.AddTransient<EmailNewUser>();
            return services;
        }

        private static IServiceCollection
        AddTaskServices(this IServiceCollection services)
        {
            // add custom background tasks here
            services.AddTransient<ExampleTask>();
            return services;
        }
    }
}
