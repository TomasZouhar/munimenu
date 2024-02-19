using MuniMenu.Core.Entities;

namespace MuniMenu.Web.Models
{
    public record RestaurantVoteResponse(RestaurantType RestaurantType, ICollection<string> UserIds);
}
