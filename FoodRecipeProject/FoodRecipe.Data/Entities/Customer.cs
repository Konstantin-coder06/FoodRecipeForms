using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Recipe> Recipes { get; set; }


    }
}
