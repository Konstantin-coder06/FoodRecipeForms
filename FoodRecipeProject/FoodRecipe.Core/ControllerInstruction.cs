using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerInstruction
    {
        FoodRecipeDbContext dbContext = new FoodRecipeDbContext();
        public string AddInstructionOfRecipe(List<string> instructions)
        {
            string output = "";
            var lastrecipe = dbContext.Recipes.OrderByDescending(x => x.Id).FirstOrDefault();
            int count = 0;
            foreach (var instructionText in instructions)
            {

                var newInstruction = new Instruction
                {
                    Recipe_Id = lastrecipe.Id,
                    Step_Number = count + 1,
                    Instruction_Text = instructionText
                };
                dbContext.Instructions.Add(newInstruction);
                count++;
            }
            dbContext.SaveChanges();
            output = "Добави инструкции успешно";
            return output;
        }

    }
            
}
    

