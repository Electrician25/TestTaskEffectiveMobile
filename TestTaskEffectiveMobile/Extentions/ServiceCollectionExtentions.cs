using Microsoft.Extensions.DependencyInjection;
using TestTaskEffectiveMobile.FileServices;

namespace TestTaskEffectiveMobile.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddFileServices(this IServiceCollection services)
        {
            services.AddTransient<FileReader>();
            services.AddTransient<FileWriter>();
            services.AddTransient<FileWriterByDate>();
            services.AddTransient<FileWriterByAddresMask>();

            return services;
        }
    }
}