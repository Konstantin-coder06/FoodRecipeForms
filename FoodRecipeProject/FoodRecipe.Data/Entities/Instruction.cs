using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class Instruction
    {
        public int Id { get; set; }
        [ForeignKey("Recipe")]
        public int Recipe_Id { get; set; }
        public Recipe Recipe { get; set; }
     
        public int Step_Number {  get; set; }
        public string Instruction_Text {  get; set; }
    }
}
