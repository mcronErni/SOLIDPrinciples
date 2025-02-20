using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Notification
    {
        private readonly INotificationService _notificationService;

        public Notification(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PromotionalNotification()
        {
            var content = "You have won a gift!";
            _notificationService.SendNotification(content);
        }
    }
}
