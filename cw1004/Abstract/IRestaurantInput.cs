using cw1004.Model;

namespace cw1004.Abstract
{
    public interface IRestaurantInput
    {
        public RestaurantInfo? Get(int id);
        public List<RestaurantInfo> GetAll();
    }
}
