using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IResturant
    {
        public IEnumerable<Resturant> GetAll();

        public IEnumerable<Resturant> GetResturantByName(string name);

        public Resturant GetResturantById(int id);
    }

    public class InMemoryResturantData : IResturant
    {
        private List<Resturant> resturants;

        public InMemoryResturantData() {
            resturants = new List<Resturant> { new Resturant { id = 1, Name = "Scott's Pizza", Location = "Viman Nagar", CuisineType = Resturant.Cuisine.Indian } ,
            new Resturant { id = 2, Name = "Vaibhav's Fries", Location = "Koregaon Park", CuisineType = Resturant.Cuisine.Indian },
            new Resturant { id = 3, Name = "Modi's Burger", Location = "Camp", CuisineType = Resturant.Cuisine.Indian }};
        }
        public IEnumerable<Resturant> GetAll()
        {
            return from r in resturants select r;
        }

        public IEnumerable<Resturant> GetResturantByName(string name = null) {

            return from r in resturants orderby r.Name where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) select r;
        }


        public Resturant GetResturantById(int Id) {
            return resturants.SingleOrDefault(r => r.id == Id); 
        }
    }
}
