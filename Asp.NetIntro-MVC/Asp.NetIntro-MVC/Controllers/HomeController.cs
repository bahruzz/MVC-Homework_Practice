using Asp.NetIntro_MVC.Models;
using Asp.NetIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetIntro_MVC.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index()
        {
            int AgeOfAykhan = 24;
            string text = "Welcome";
            List<string> students = new List<string> { "Bahruz", "Reshad", "Esgerxan","Elmir" };

            HomeVM model = new HomeVM()
            {
                Text = text,
                Students = students,
                AgeOfAykhan=AgeOfAykhan,
                Users=GetAllUsers()
                
            };    
            return View(model);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id=1,
                    Age=100
                },
                 new User
                {
                    Id=2,
                    Age=45
                }
            };
        } 
    }
}
