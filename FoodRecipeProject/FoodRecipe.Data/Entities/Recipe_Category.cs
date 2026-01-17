using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Recipe_Category
    {
        public int Id {  get; set; }
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
