using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerSubCategory
    {
        FoodRecipeDbContext dbContext=new FoodRecipeDbContext();
        public string AddSubCategory(string name,string nameofCat)
        {
            
            string output = "";
            var category=dbContext.Categories.FirstOrDefault(x=>x.Name.ToLower()==nameofCat.ToLower());
            if (category != null)
            {


                var subcategory = dbContext.SubCategories.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
                if (subcategory != null)
                {
                    output = "There is category with this name";
                }
                else
                {
                    SubCategory subCategory = new SubCategory()
                    {
                        Name = name,
                        CategoryId = category.Id,
                    };
                    dbContext.SubCategories.Add(subCategory);
                    dbContext.SaveChanges();
                    output = "Successfully added category";
                }
            }
                return output;
            
        }
    }
}
