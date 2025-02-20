using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailService();
            Notification notifByEmail = new Notification(emailService);

            INotificationService smsService = new SMSService();
            Notification notifBySms = new Notification(smsService);

            notifByEmail.PromotionalNotification();
            notifBySms.PromotionalNotification();
        }
    }
}
