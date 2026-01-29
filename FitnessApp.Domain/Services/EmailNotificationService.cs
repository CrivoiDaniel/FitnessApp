using FitnessApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void sendNotification(string message, string recipient)
        {
            System.Console.WriteLine($"Email send to {recipient}: {message}");
        }
    }
}
