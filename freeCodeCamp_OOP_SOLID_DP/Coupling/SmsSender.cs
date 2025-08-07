﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("SMS message : " + message);
        }
    }
}
