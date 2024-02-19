using MuniMenu.Adapters.ThirdParty.Restaurants;
using MuniMenu.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MuniMenu.Adapters.ThirdParty.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRestaurants(this IServiceCollection services)
        {
            //TODO use Scrutor
            services.AddSingleton<IRestaurant, AnnapurnaRestaurant>();
            services.AddSingleton<IRestaurant, DivaBaraRestaurant>();
            
            return services;
        }
    }
}
