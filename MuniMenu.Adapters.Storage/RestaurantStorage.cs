using MuniMenu.Core.Entities;
using MuniMenu.Domain.Contracts;
using MuniMenu.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace MuniMenu.Adapters.Storage
{
    internal class RestaurantStorage : IRestaurantStorage
    {
        private readonly IDistributedCache _cache;

        public RestaurantStorage(IDistributedCache cache)
        {
            _cache = cache;
        }

        public Task<Restaurant> FindAsync(RestaurantType restaurantType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Restaurant>> GetAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StoreAsync(Restaurant restaurant, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
