﻿using System.Security.Cryptography.X509Certificates;

namespace ProjectTwoGroup3.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    // .WithOrigins("http://www.skillstorm.com")
                    .AllowAnyOrigin()
                    // .WithMethods("POST", "PUT", "DELETE", "GET")
                    .AllowAnyMethod()
                    // .WithHeaders("accept", "content-type")
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
    }
}