using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerCategory
    {
        FoodRecipeDbContext dbContext=new FoodRecipeDbContext();
        public string AddCategory(string name)
        {
            string output = "";
            var category = dbContext.Categories.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
            if(category != null)
            {
                output = "There is category with this name";
            }
            else
            {
                Category category1= new Category()
                {
                    Name = name
                };
                dbContext.Categories.Add(category1);
                dbContext.SaveChanges();    
                output = "Successfully added category";
            }
            return output;
        }
        public string ShowAllCategory()
        {
            string output = "";
            var category = dbContext.Categories.ToList();
            if(category != null)
            {
                foreach(var c in category)
                {
                    output += $"{c.Name}\n";
                }
            }
            else
            {
                output = "There is no categories";
            }
            return output;
        }
    }
}
