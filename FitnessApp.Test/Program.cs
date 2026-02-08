using System;
using System.Collections.Generic;
using FitnessApp.Domain.Entities;
using FitnessApp.Domain.Interfaces;
using FitnessApp.Domain.Services;

namespace FitnessApp.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();
            GymManager gymManager = new GymManager(emailService);

            List<User> gymUsers = new List<User>
            {
                new Client(101, "Ion Popescu", "ion@yahoo.com", "Abonament Premium"),
                new Trainer(201, "Alex Antrenorul", "alex.fit@gym.com", "CrossFit & Yoga"),
                new AdminUser(301, "Elena Admin", "admin@gym.com")
            };

            foreach (var user in gymUsers)
            {
                Console.WriteLine(user.getDetails());
            }

            var client = (Client)gymUsers[0];
            client.bookSession("Yoga");

            var trainer = (Trainer)gymUsers[1];
            trainer.setAvailability("18:00 - 20:00");

            var admin = (AdminUser)gymUsers[2];
            admin.manageEquipment("Banda de alergat nr. 5", "In Reparatie");

            gymManager.RegisterClient(client);
        }
    }
}