using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Text.RegularExpressions;
using System.ComponentModel.Design;

namespace FoodRecipe.Core
{
    public class ControllerRecipe
    {
        FoodRecipeDbContext dbContext=new FoodRecipeDbContext();
        ControllerCustomer customer=new ControllerCustomer();
       public int AddedRecipeId {  get; set; }
       
        public string AddRecipe(string name, string description, int prep, int cook, int servings,int idCustomer)
        {
            string output = "";
        
          
            var recipe=dbContext.Recipes.FirstOrDefault(x=>x.Name==name && x.Description==description);
            if(recipe==null)
            {
               Recipe recipe1 = new Recipe()
                {
                    Name = name,
                    Description = description,
                    Prep_time = prep,
                    Cook_time = cook,
                    Servings = servings,
                    CustomerId = idCustomer,

                };
                dbContext.Recipes.Add(recipe1);
                dbContext.SaveChanges();
                AddedRecipeId = recipe1.Id;


                ControllerRecipe_Ingredient controllerRecipeIngredient = new ControllerRecipe_Ingredient();
                int id=SearchRecipe(name, description);
                //controllerRecipeIngredient.AddedRecipeId = id;
                output = "Успешно е добавена рецептата";
            }
            else
            {             
                AddedRecipeId = recipe.Id;
                output = "Успешно е добавена рецептата";
            }
            return output;
        }
        public int SearchRecipe(string name,string description)
        {
            var recipe= dbContext.Recipes.FirstOrDefault(x=>x.Name == name && x.Description==description);
            int id = 0;
            if(recipe!=null)
            {
                id= recipe.Id;
            }
           return id;
        }
        public string ShowAllRecipes()
        {
            string output = "";
            var recipes=dbContext.Recipes.ToList();

            foreach(var recipe in recipes)
            {
              
                
                output+= $"--{recipe.Id}--\n   Name: {recipe.Name}, Description: {recipe.Description},\n  Prep Time: {recipe.Prep_time}, Cook Time: {recipe.Cook_time}, Servings: {recipe.Servings}\n\n";
            }
            return output;
        }
        public string RecipeSearchByName(string name)
        {
            var output = "";


            var categories = dbContext.SubCategories.FirstOrDefault(x => x.Name.ToLower()==name.ToLower());
            if (categories != null)
            {
                var mapping = dbContext.Recipe_Categories.Where(x => x.SubCategoryId == categories.Id).ToList();


                foreach (var r in mapping)
                {
                    var recipe = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);
                    if (recipe != null)
                    {


                        output += $"--{recipe.Id}--\n   Name: {recipe.Name}, Description: {recipe.Description},\n  Prep Time: {recipe.Prep_time}, Cook Time: {recipe.Cook_time}, Servings: {recipe.Servings}\n\n";
                    }
                    if (recipe == null)
                    {
                        output = "Няма все още такава рецепта, но меже да добавиш такава като се регистрираш";
                    }
                }
            }
          
            return output;
        }
        public string ChangeNameOfRecipe(int id,string newname)
        {
            string output = "";
            var recipe=dbContext.Recipes.FirstOrDefault(x=>x.Id==id);
            if (recipe != null)
            {
                recipe.Name = newname;
               
                dbContext.SaveChanges();
                output = "Успешно промени името на рецептата";
            }
            return output;
        }
        public string SearchByCategoryWithId(string categoryName)
        {
            string output = "";
            var categories = dbContext.SubCategories.FirstOrDefault(x => x.Name.ToLower().Trim() == categoryName.ToLower().Trim());
            if (categories != null)
            {
                var mapping = dbContext.Recipe_Categories.Where(x => x.SubCategoryId == categories.Id).ToList();


                foreach (var r in mapping)
                {
                    var recipe = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);
                    if (recipe != null)
                    {


                        output += $"--{recipe.Id}--\n   Name: {recipe.Name}, Description: {recipe.Description},\n  Prep Time: {recipe.Prep_time}, Cook Time: {recipe.Cook_time}, Servings: {recipe.Servings}\n\n";
                    }
                   else
                    {
                       
                            output = "Все още няма такава рецепта, но ти може да добавиш :)";
                        
                    }
                }
            }
           
            else
            {
                output = "Category Not Found or not in Database";
            }
           
            return output;
            
        }
        public string SearchByCategoryWithoutId(string categoryName)
        {
            string output = "";
            var categories = dbContext.SubCategories.FirstOrDefault(x => x.Name.ToLower().Trim() == categoryName.ToLower().Trim());
            if (categories != null)
            {
                var mapping = dbContext.Recipe_Categories.Where(x => x.SubCategoryId == categories.Id).ToList();
                if (mapping.Count>0)
                {
                    foreach (var r in mapping)
                    {
                        var recipe = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);

                        if (recipe != null)
                        {


                            output += $" Име: {recipe.Name}, Послание: {recipe.Description},\n  Време за приготвяне: {recipe.Prep_time}, Време за готвене: {recipe.Cook_time}, Порции: {recipe.Servings}\n\n";
                        }

                    }
                }
                else
                {
                    output = "Все още няма такава рецепта, но ти може да добавиш :)";
                }
            }
            else
            {
                output = "Category Not Found or not in Database";
            }
            return output;
        }
        public string SearchByCategoryWithoutIdWithInstructions(string categoryName)
        {
            string output = "";
            var categories = dbContext.SubCategories.FirstOrDefault(x => x.Name.ToLower().Trim() == categoryName.ToLower().Trim().Trim());
            if (categories != null)
            {
                var mapping = dbContext.Recipe_Categories.Where(x => x.SubCategoryId == categories.Id).ToList();
                if (mapping.Count > 0)
                {
                    foreach (var r in mapping)
                    {
                        string instr = "";
                        string ingred = "";
                       
                        var recipe = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);
                        var mappingIngredients = dbContext.Recipe_Ingredients.Where(x => x.RecipeId == recipe.Id).ToList();
                        foreach (var i in mappingIngredients)
                        {
                           var ingredients = dbContext.Ingredients.Where(x => x.Id == i.IngredientId).ToList();
                            foreach (var ing in ingredients)
                            {
                                ingred +=$"   {ing.Name} - {i.IngredientQuantity}\n";
                            }
                        }
                      
                        var instructions = dbContext.Instructions.Where(x => x.Recipe_Id == recipe.Id);
                        foreach (var i in instructions)
                        {
                            instr += $"№{i.Step_Number}- {i.Instruction_Text}\n";
                        }
                       
                         
                            output += $" Име: {recipe.Name}, Послание: {recipe.Description},\n  Време за приготвяне: {recipe.Prep_time}, Време за готвене: {recipe.Cook_time}, Порции: {recipe.Servings}\n--Съставки–\n{ingred}\n {instr}\n\n";

                        

                    }
                }
                else
                {
                    output = "Все още няма такава рецепта, но ти може да добавиш :)";
                }
            }
            else
            {
                output = "Category Not Found or not in Database";
            }
            return output;
        }
        public string DeleteRecipe(int id)
        {
            string output = "";
            var recipe=dbContext.Recipes.FirstOrDefault(x=>x.Id == id);
            if (recipe != null)
            {
                dbContext.Recipes.Remove(recipe);
                dbContext.SaveChanges();
                output = "Deleted successfully";
            }
            else
            {
                output = "There is no recipe with this number";
            }
            return output;
        }
        public string Drinks()
        {
            string output = "";
            var drinks = dbContext.SubCategories.FirstOrDefault(x => x.Name == "Напитки");
            if (drinks != null)
            {

                var mapping=dbContext.Recipe_Categories.Where(x=>x.SubCategoryId==drinks.Id).ToList();
                foreach (var r in mapping) 
                {
                    var recipes = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);
                    if (recipes != null)
                    {


                        output += $" Име: {recipes.Name}, Послание: {recipes.Description},\n  Време за приготвяне: {recipes.Prep_time}, Време за готвене: {recipes.Cook_time}, Порции: {recipes.Servings}\n\n";
                    }
                    else
                    {
                        output = "Все още няма салати, но ти можеш да добавиш :)";
                    }
                }
            }
            else
            {
                output = "Няма такава категория";
            }
            return output;
        }
        public string Salads()
        {
            string output = "";
            var drinks = dbContext.SubCategories.FirstOrDefault(x => x.Name == "Салати");
            if (drinks != null)
            {

                var mapping = dbContext.Recipe_Categories.Where(x => x.SubCategoryId == drinks.Id).ToList();
                foreach (var r in mapping)
                {
                    var recipes = dbContext.Recipes.FirstOrDefault(x => x.Id == r.RecipeId);
                    if (recipes != null)
                    {


                        output += $" Име: {recipes.Name}, Послание: {recipes.Description},\n  Време за приготвяне: {recipes.Prep_time}, Време за готвене: {recipes.Cook_time}, Порции: {recipes.Servings}\n\n";
                    }
                    else
                    {
                        output = "Все още няма салати, но ти можеш да добавиш :)";
                    }
                }
            }
            else
            {
                output = "Няма такава категория";
            }
            return output;
        }
        public string SearchByName(string name)
        {
            string output = "";
            var recipes = dbContext.Recipes.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
          
                foreach (var r in recipes)
                {
                    string instr = "";
                    string ingred = "";

                  
                    var mappingIngredients = dbContext.Recipe_Ingredients.Where(x => x.RecipeId == r.Id).ToList();
                    foreach (var i in mappingIngredients)
                    {
                        var ingredients = dbContext.Ingredients.Where(x => x.Id == i.IngredientId).ToList();
                        foreach (var ing in ingredients)
                        {
                            ingred += $"   {ing.Name} - {i.IngredientQuantity}\n";
                        }
                    }

                    var instructions = dbContext.Instructions.Where(x => x.Recipe_Id == r.Id);
                    foreach (var i in instructions)
                    {
                        instr += $"№{i.Step_Number}- {i.Instruction_Text}\n";
                    }
                   
                        output += $" Име: {r.Name}, Послание: {r.Description},\n  Време за приготвяне: {r.Prep_time}, Време за готвене: {r.Cook_time}, Порции: {r.Servings}\n--Съставки–\n{ingred}\n {instr}\n\n";

                    
                }
            
            return output;
        }
        public string ShowAllRecipe()
        {
            string output = "";
            var recipes = dbContext.Recipes.ToList();

            foreach (var r in recipes)
            {
                string instr = "";
                string ingred = "";


                var mappingIngredients = dbContext.Recipe_Ingredients.Where(x => x.RecipeId == r.Id).ToList();
                foreach (var i in mappingIngredients)
                {
                    var ingredients = dbContext.Ingredients.Where(x => x.Id == i.IngredientId).ToList();
                    foreach (var ing in ingredients)
                    {
                        ingred += $"   {ing.Name} - {i.IngredientQuantity}\n";
                    }
                }

                var instructions = dbContext.Instructions.Where(x => x.Recipe_Id == r.Id);
                foreach (var i in instructions)
                {
                    instr += $"№{i.Step_Number}- {i.Instruction_Text}\n";
                }

                output += $"Име: {r.Name}, Послание: {r.Description},\n  Време за приготвяне: {r.Prep_time}, Време за готвене: {r.Cook_time}, Порции: {r.Servings}\n--Съставки–\n{ingred}\n--Инструкции--\n{instr}\n\n";


            }

            return output;
        }
    }
}
