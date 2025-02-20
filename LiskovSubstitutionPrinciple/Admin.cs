using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Admin : User, IAdminAccount
    {
        public Admin(string name) : base(name)
        {
            //AccessAdmin();
        }

        public void AccessAdmin()
        {
            Console.WriteLine($"{base.Name} Accessed Admin Panel");
        }
    }
}
