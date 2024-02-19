using MuniMenu.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace MuniMenu.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantFacade _restaurantFacade;

        public HomeController(IRestaurantFacade restaurantFacade)
        {
            _restaurantFacade = restaurantFacade;
        }

        [ResponseCache(Duration = 60)]
        public async Task<IActionResult> Index()
        {
            var restaurants = await _restaurantFacade.GetAsync();

            return View(restaurants);
        }
    }
}