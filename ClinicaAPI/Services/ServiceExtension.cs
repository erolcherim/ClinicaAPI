using Microsoft.Extensions.DependencyInjection;
using System;
using ClinicaAPI.DAL.Seeders;
using ClinicaAPI.Services.AuthServices;

namespace ClinicaAPI.Services
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
        }

        public static void AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<InitialSeed>();
        }
    }
}