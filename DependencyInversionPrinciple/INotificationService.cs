﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal interface INotificationService
    {
        void SendNotification(string notifContent);
    }
}
