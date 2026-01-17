using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Ingredient
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public ICollection< Recipe_Ingredient> Recipe { get; set; }
    }
}
