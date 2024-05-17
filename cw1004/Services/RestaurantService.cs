using cw1004.Abstract;
using cw1004.Model;

namespace cw1004.Services
{
    public class RestaurantService : IRestaurantInput
    {
        public readonly List<RestaurantInfo> All = [
            new RestaurantInfo() {
                Id = 1,
                Name = "Restaurant A",
                Stars = 5,
            },
            new RestaurantInfo() {
                Id = 2,
                Name = "Restaurant B",
                Stars = 4,
            },
            new RestaurantInfo() {
                Id = 3,
                Name = "Restaurant C",
                Stars = 5,
            },
            new RestaurantInfo() {
                Id = 4,
                Name = "Restaurant D",
                Stars = 2,
            }
        ];

        public RestaurantInfo? Get(int id) {
            return All.Find(x => x.Id == id);
        }

        public List<RestaurantInfo> GetAll() {
            return All;
        }
    }
}
