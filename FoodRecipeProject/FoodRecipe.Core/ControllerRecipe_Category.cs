using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerRecipe_Category
    {
        FoodRecipeDbContext dbContext = new FoodRecipeDbContext();  
        public string AddRecipeToCategory(string name)
        {
            string output = "";
            var nameofcat=dbContext.SubCategories.FirstOrDefault(x=>x.Name.ToLower()==name.ToLower());
            var lastRecipe=dbContext.Recipes.OrderByDescending(x=>x.Id).FirstOrDefault();
            if (lastRecipe != null && nameofcat != null)
            {
                Recipe_Category category = new Recipe_Category()
                {
                    RecipeId = lastRecipe.Id,
                    SubCategoryId = nameofcat.Id
                };
                dbContext.Recipe_Categories.Add(category);
                dbContext.SaveChanges();
                output = "Успешно добавихте рецептата към категорията";
            }
            return output;
        }
    }
}
