using FoodRecipe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data
{
    public class FoodRecipeDbContext:DbContext
    {
        public FoodRecipeDbContext()
        {

        }
        public FoodRecipeDbContext(DbContextOptions<FoodRecipeDbContext> options) : base(options) 
        {
            
        }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set;}
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
       
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Recipe_Category> Recipe_Categories { get; set;}
        public virtual DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }
        public virtual DbSet<Contact>Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FoodRecipeDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ingredient>().Property(x=>x.Name).ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>().Property(x => x.Email).ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>().Property(x=>x.Password).ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(x => x.Name).ValueGeneratedOnAdd();
            modelBuilder.Entity<Instruction>().HasIndex(x=>new {x.Recipe_Id, x.Step_Number}).IsUnique();
            modelBuilder.Entity<Contact>().Property(x=>x.Id).ValueGeneratedOnAdd();
        }
    }
}
