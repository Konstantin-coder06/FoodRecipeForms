using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
       
        public double Prep_time {  get; set; }
        public double Cook_time {  get; set; }
        public int Servings {  get; set; }
        [ForeignKey("Customer")]
       public int CustomerId {  get; set; }
        public Customer Customer { get; set; }
        public ICollection<Recipe_Category> Category { get; set; }
        public ICollection< Instruction> Instruction { get; set; }
        public ICollection<Recipe_Ingredient> Ingredient { get; set; }
    }
}
