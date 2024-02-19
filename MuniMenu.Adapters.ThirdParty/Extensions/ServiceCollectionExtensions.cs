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
            services.AddSingleton<IRestaurant, DivaBaraRestaurant>();
            services.AddSingleton<IRestaurant, NaRuzkuRestaurant>();
            services.AddSingleton<IRestaurant, AlcaponeRestaurant>();
            services.AddSingleton<IRestaurant, UDrevakaRestaurant>();
            services.AddSingleton<IRestaurant, UKarlaRestaurant>();
            services.AddSingleton<IRestaurant, BistroMinisteroRestaurant>();
            services.AddSingleton<IRestaurant, PlzenskyDvurRestaurant>();
            services.AddSingleton<IRestaurant, TheImmigrantRestaurant>();
            services.AddSingleton<IRestaurant, GardenFoodConceptRestaurant>();
            services.AddSingleton<IRestaurant, GardenRestaurant>();
            services.AddSingleton<IRestaurant, StavbaRestaurant>();
            services.AddSingleton<IRestaurant, UMachalaRestaurant>();
            services.AddSingleton<IRestaurant, ZelenaKockaRestaurant>();
            services.AddSingleton<IRestaurant, AnnapurnaRestaurant>();
            
            return services;
        }
    }
}
