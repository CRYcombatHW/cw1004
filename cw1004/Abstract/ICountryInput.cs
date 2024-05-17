using cw1004.Model;

namespace cw1004.Abstract
{
    public interface ICountryInput
    {
        public CountryInfo? Get(int id);
        public List<CountryInfo> GetAll();
    }
}
