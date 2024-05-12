using Homework.Models;
using Homework.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            HomeVM model = new HomeVM()
            {
                Students = GetAllStudents().OrderByDescending(u => u.Age).ToList(),
                Products = GetAllProducts(),
            };
            return View(model);
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Name = "Bahruz",
                    Surname="Aliyev",
                    Email="bahruz@code.edu.az",
                    Age=37,
                    Phone=45569885
                },
                new Student
                {
                    Name = "Rashad",
                    Surname="Agayev",
                    Email="rashad@code.edu.az",
                    Age=21,
                    Phone=37569885
                },
                new Student
                {
                    Name = "Esgerxan",
                    Surname="Bayramov",
                    Email="esgerxan@code.edu.az",
                    Age=93,
                    Phone=65894545
                },
                new Student
                {
                    Name = "Amirastan",
                    Surname="Miriyev",
                    Email="amirastan@code.edu.az",
                    Age=24,
                    Phone=45568556
                }
            };
        }
        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="Iphone15",
                    Color="Black",
                    Price=2500
                },
                 new Product
                {
                    Name="SamungGalaxyS24",
                    Color="Red",
                    Price=1900
                },
                  new Product
                {
                    Name="Xiaomi",
                    Color="Green",
                    Price=1000
                },
                   new Product
                {
                    Name="Iphone14",
                    Color="Gold",
                    Price=1800
                },
            };
        }
    }
}
