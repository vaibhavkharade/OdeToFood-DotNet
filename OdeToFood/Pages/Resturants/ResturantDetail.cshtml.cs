using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class ResturantDetailModel : PageModel
    {
        public IResturant resturant;

        public Resturant rest { get; set; }

        public ResturantDetailModel(IResturant resturant) {
            this.resturant = resturant;
            rest = new Resturant();
        }
        public void OnGet(int Id)
        {
            rest = resturant.GetResturantById(Id);
        }
    }
}
