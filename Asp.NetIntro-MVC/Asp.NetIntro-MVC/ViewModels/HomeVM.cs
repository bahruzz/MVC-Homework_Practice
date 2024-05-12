using Asp.NetIntro_MVC.Models;

namespace Asp.NetIntro_MVC.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }

        public int AgeOfAykhan { get; set; }

        public List<User> Users { get; set; }
    }
}
