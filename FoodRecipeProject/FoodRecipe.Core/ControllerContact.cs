using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerContact
    {
        FoodRecipeDbContext dbContext = new FoodRecipeDbContext();
        public string AddAdvice(string name, string email, string title, string text)
        {
            string output = "";
            var advice=dbContext.Contacts.FirstOrDefault(x=>x.Name==name && x.Email==email &&x.Title==title && x.Text==text);
            if (advice==null)
            {
                Contact contact = new Contact()
                {
                    Name = name,
                    Email = email,
                    Title = title,
                    Text = text
                };
                dbContext.Contacts.Add(contact);
                dbContext.SaveChanges();
                output = "Успешно добавихте";
            }
            else
            {
                output = "Вече си пратил същото запитване. Моля, не натоварвай базата данни";
            }
            return output;
        }
        public string ShowAllAdvices()
        {
            string output = "";
            var advice= dbContext.Contacts.ToList();
            foreach(var adv in advice)
            {
                output += $"{adv.Name}- Title {adv.Title} Text {adv.Text}\n\n";
            }
            return output;

        }
    }
}
