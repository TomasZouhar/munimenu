using MuniMenu.Core.Entities;
using MuniMenu.Domain.Entities;

namespace MuniMenu.Domain.Contracts
{
    public interface IRestaurantStorage
    {
        Task<ICollection<Restaurant>> GetAsync(CancellationToken cancellationToken);
        Task<Restaurant> FindAsync(RestaurantType restaurantType, CancellationToken cancellationToken);
        Task StoreAsync(Restaurant restaurant, CancellationToken cancellationToken);
    }
}
