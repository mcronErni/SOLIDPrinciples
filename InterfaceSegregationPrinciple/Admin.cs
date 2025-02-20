using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Admin : Employee, IAdmin
    {
        public Admin(string role) : base(role)
        {
        }

        public void DeleteUser()
        {
            Console.WriteLine($"{Role} Delted A User.");
        }
    }
}
