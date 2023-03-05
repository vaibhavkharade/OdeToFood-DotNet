using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages
{
    public class ResturantsModel : PageModel
    {
        private readonly IConfiguration _config;

        private readonly IResturant resturant;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Resturant> resturants { get; set; }
        public string? Message { get; set; }
        public ResturantsModel(IConfiguration config , IResturant resturant) {
            _config = config;
            this.resturant = resturant;
        } 

        public void OnGet()
        {
            Message = _config["Message"];
            resturants = resturant.GetResturantByName(SearchTerm);
        }
    }
}
