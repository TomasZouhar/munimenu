using MuniMenu.Core.Entities;
using MuniMenu.Domain.Entities;

namespace MuniMenu.Domain.Contracts
{
    public interface IMenuProvider
    {
        Task<Menu> GetMenuAsync(RestaurantType restaurantType, CancellationToken cancellationToken);
    }
}
