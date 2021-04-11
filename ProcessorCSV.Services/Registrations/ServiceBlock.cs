using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProcessorCSV.Services.Document;
using ProcessorCSV.Services.Upload;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Registrations
{
    public static class ServiceBlock
    {
        /// <summary>
        /// Register Core Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection CoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IDocumentService, DocumentService>();
            return services;
        }
    }
}
