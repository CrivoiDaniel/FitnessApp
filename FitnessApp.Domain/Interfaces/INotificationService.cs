using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Interfaces
{
    public interface INotificationService
    {
         void sendNotification(string message, string recipient);
    }
}
