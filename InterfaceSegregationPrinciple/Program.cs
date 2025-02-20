using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Employee");
            Manager manager = new Manager("Manager");
            Admin admin = new Admin("Admin");

            Program program = new Program();
            program.DoSomething(employee);
            program.DoSomething(manager);
            program.DoSomething(admin);
        }

        public void DoSomething(Employee employee)
        {
            employee.TimeIn();
            employee.Work();

            if(employee is IManager manager)
            {
                manager.Manage();
            }

            if (employee is IAdmin admin)
            {
                admin.DeleteUser();
            }
        }
    }
}