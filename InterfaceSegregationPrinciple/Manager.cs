using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Manager : Employee, IManager
    {
        public Manager(string role) : base(role)
        {
        }

        public void Manage()
        {
            Console.WriteLine($"{Role} Managed something.");
        }
    }
}
