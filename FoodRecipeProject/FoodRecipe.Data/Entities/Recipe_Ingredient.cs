using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Recipe_Ingredient
    {
        public int Id { get; set; }
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }
        public string IngredientQuantity { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
