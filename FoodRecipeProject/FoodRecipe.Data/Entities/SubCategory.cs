using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Entities
{
    public class SubCategory
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection< Recipe_Category> Recipe_Category { get; set; }
     
    }
}
