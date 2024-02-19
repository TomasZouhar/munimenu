using MuniMenu.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MuniMenu.Adapters.Storage.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddStorages(this IServiceCollection services)
        {
            services.AddSingleton<IRestaurantStorage, RestaurantStorage>();

            return services;
        }
    }
}
