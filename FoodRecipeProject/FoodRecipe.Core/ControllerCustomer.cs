using FoodRecipe.Data;
using FoodRecipe.Data.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Core
{
    public class ControllerCustomer
    {
        FoodRecipeDbContext dbContext=new FoodRecipeDbContext();
      
        public string SignIn(string email, string password)
        {
            string output ="";
            var user = dbContext.Customers.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (user == null)
            {
                output ="Няма такъв потребител";
                
            }
            else
            {
                
                output ="Успешно влязохте";
                if (user.IsAdmin == true)
                {
                    output += " Admin";
                }
                          
            }
            return output;
        }
        public Customer GetUserByEmail(string email)
        {
            return dbContext.Customers.FirstOrDefault(x => x.Email == email);
        }
        public string SignUp(string name,string email,string password)
        {
            string output = "";
            var isThereUser = dbContext.Customers.FirstOrDefault(x => x.Email == email);
            if(isThereUser != null)
            {
                output = "Зает е този имайл адрес!";
            }
            else
            {
                Customer customer = new Customer()
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    IsAdmin = false
                };
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
                output = "Успешно се регистрирахте";
            }
            return output;
        }
        public string ShowAllCustomers()
        {
            string output = "";
            var users=dbContext.Customers.Where(x=>x.IsAdmin==false).ToList();
            foreach (var user in users)
            {
                output += $"-{user.Name}-  Email:{user.Email}\n";
            }
            return output;
        }
        public string DeleteUser(string email)
        {
            string output = "";
            var user = dbContext.Customers.FirstOrDefault(x=>x.Email == email);
            if (user!=null)
            {
                dbContext.Customers.Remove(user);
                dbContext.SaveChanges();
                output = "You delete this user";
            }
            return output;
        }
        public int GetIdReg(string name, string email, string password)
        {
            int output =0;
            var user=dbContext.Customers.FirstOrDefault(x=>x.Name==name && x.Email==email && x.Password==password);
            output = user != null ? user.Id : 0;
            return output;
        }
    }
}
