using cw1004.Abstract;
using cw1004.Model;

namespace cw1004.Services
{
    public class CountryService : ICountryInput
    {
        public readonly List<CountryInfo> All = [
            new CountryInfo() {
                Id = 1,
                Name = "Ukraine",
                Area = 603628,
            },
            new CountryInfo() {
                Id = 2,
                Name = "Russia",
                Area = 17098242,
            },
            new CountryInfo() {
                Id = 3,
                Name = "USA",
                Area = 9833520,
            },
            new CountryInfo() {
                Id = 4,
                Name = "China",
                Area = 9597000,
            },
            new CountryInfo() {
                Id = 4,
                Name = "Japan",
                Area = 377973,
            }
        ];

        public CountryInfo? Get(int id) {
            return All.Find(x => x.Id == id);
        }

        public List<CountryInfo> GetAll() {
            return All;
        }
    }
}
