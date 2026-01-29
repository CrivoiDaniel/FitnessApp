using FitnessApp.Domain.Entities;
using FitnessApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Services
{
    public class GymManager
    {
        private readonly INotificationService _notificationService;

        public GymManager(INotificationService notificationService) {
            _notificationService = notificationService;
        }
        public void RegisterClient(Client client)
        {
            System.Console.WriteLine($"Register client: {client.Name}");
            _notificationService.sendNotification("Welcome to our gym!", client.Email);
        }


    }
}
