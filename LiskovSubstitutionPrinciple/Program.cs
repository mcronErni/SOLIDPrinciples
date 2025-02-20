using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Admin admin = new Admin("admin");
            Employee Employee = new Employee("member");
            program.DoSomething(admin);
            program.DoSomething(Employee);
        }


        public void DoSomething(User user)
        {
            user.LogIn();
            //user.AccessAdmin();

            if(user is IAdminAccount adminAccount)
            {
                adminAccount.AccessAdmin();
            }

            user.LogOut();
        }
    }
}
