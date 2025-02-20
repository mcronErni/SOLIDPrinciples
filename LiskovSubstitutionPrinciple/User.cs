using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class User
    {
        protected string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
        public void LogIn()
        {
            Console.WriteLine($"{Name} is now Logged In");
        }
        public void LogOut()
        {
            Console.WriteLine($"{Name} is Logged Out");
        }
    }
}
