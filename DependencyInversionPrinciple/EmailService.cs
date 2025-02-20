using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class EmailService : INotificationService
    {
        public void SendNotification(string notifContent)
        {
            Console.WriteLine($"SENT VIA EMAIL:\n{notifContent}");
        }
    }
}
