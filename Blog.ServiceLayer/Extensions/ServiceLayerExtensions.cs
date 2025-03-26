using Blog.ServiceLayer.Services.Abstraction;
using Blog.ServiceLayer.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blog.ServiceLayer.Services.Abstraction;
using System.Reflection;

namespace Blog.ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {

            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
