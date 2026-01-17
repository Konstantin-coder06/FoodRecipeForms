using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerRecipe_Ingredient
    {
        FoodRecipeDbContext dbContext=new FoodRecipeDbContext();
        ControllerRecipe controllerRecipe=new ControllerRecipe();
     
       
         public string AddRecIng(List<string> ing, List<string>quantity)
         {
         int lastId=dbContext.Recipes.OrderByDescending(x=>x.Id).Select(x=>x.Id).FirstOrDefault();
            int id=lastId;
             string output = "";
             List<int>idsOfIng = new List<int>();
             foreach (string ingItem in ing)
             {
                 var ings = dbContext.Ingredients.FirstOrDefault(x => x.Name == ingItem);
                 if (ings != null)
                 {
                     idsOfIng.Add(ings.Id);
                 }
             }
            for(int i=0;i<idsOfIng.Count;i++)
            {
                Recipe_Ingredient recipe_Ingredient = new Recipe_Ingredient()
                {
                    RecipeId = lastId,
                    IngredientId = idsOfIng[i],
                    IngredientQuantity = quantity[i]
                 };
                 dbContext.Recipe_Ingredients.Add(recipe_Ingredient);
                 dbContext.SaveChanges();
                 output = "Успешно добавихте продуктите към рецептата";
             }
             return output;
         }

    }
}
