using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Employee : IEmployee
    {
        public string Role { get; set; }
        public Employee(string role)
        {
            Role = role;
        }
        public void TimeIn()
        {
            Console.WriteLine($"{Role} Timed In.");
        }

        public void Work()
        {
            Console.WriteLine($"{Role} Did Some Work.");
        }
    }
}
