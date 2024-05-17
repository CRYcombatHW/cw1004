using cw1004.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw1004.Pages
{
    public class CountrysModel : PageModel
    {
        public ICountryInput _countryInput;

        public CountrysModel(ICountryInput countryInput) {
            _countryInput = countryInput;
        }

        public void OnGet()
        {
        }
    }
}
