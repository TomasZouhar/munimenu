using MuniMenu.Domain.Entities;
using MuniMenu.Web.Models;

namespace MuniMenu.Web.Mappers
{
    public static class RestaurantMapper
    {
        public static RestaurantResponse MapToResponse(this Restaurant restaurant)
        {
            return new RestaurantResponse(
                restaurant.Type.ToString(), 
                restaurant.Menu.Soaps.Select(s => new Food(s.Name)).ToArray(), 
                restaurant.Menu.Meals.Select(s => new Food(s.Name)).ToArray(),
                0);

        }
    }
}
