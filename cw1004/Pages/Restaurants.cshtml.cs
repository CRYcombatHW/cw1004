using cw1004.Abstract;
using cw1004.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace cw1004.Pages
{
    public class RestaurantsModel : PageModel
    {
        public IRestaurantInput _restaurantInput;

        public RestaurantsModel(IRestaurantInput restaurantInput) {
            _restaurantInput = restaurantInput;
        }

        public RestaurantInfo? DetailsOfRestaurant { get; private set; }

        public void OnGet() {
            string? detailsOfId = HttpContext.Request.Query["details"].FirstOrDefault();
            if (!int.TryParse(detailsOfId, out int rId)) {
                return;
            }

            DetailsOfRestaurant = _restaurantInput.Get(rId);
        }
    }
}
