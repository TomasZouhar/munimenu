using MuniMenu.Core.Entities;
using MuniMenu.Domain.Entities;

namespace MuniMenu.Domain.Contracts
{
    public interface IRestaurant
    {
        RestaurantType Type { get; }
        Task<Restaurant> GetInfoAsync(CancellationToken cancellationToken);
    }
}
