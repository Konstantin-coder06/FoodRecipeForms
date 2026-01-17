using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerIngredient
    {
        FoodRecipeDbContext dbContext = new FoodRecipeDbContext();
        public string AddIfNess(List<string> name)
        {
            string output = "";
            foreach (var item in name)
            {
                var ingred = dbContext.Ingredients.FirstOrDefault(x => x.Name.ToLower() == item.ToLower());
                if (ingred == null)
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        Name = item,
                    };
                    dbContext.Ingredients.Add(ingredient);
                    dbContext.SaveChanges();
                    output ="Добавихте успешно продуктите";
                }
                output = "Добавихте успешно продуктите";
            }
            return output;
        }
        public string ShowAllIng()
        {
            string output = "";
            var ingredients = dbContext.Ingredients.ToList();
            if (ingredients != null)
            {
                foreach (var item in ingredients)
                {
                    output += $"{item.Name}\n";
                }
            }
            return output;
        }
        public string ChangeIngName(string old, string newname)
        {
            string output = "";
            var ing = dbContext.Ingredients.FirstOrDefault(x => x.Name == old);
            if(ing != null)
            {
                ing.Name = newname;
                dbContext.SaveChanges();
                output = "Успешно промени името на съставката";
            }
            return output;
        }
    }
}
