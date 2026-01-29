using FitnessApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Entities
{
    public class Client : User, IBookable
    {
        public string SubscriptionPlan {  get; set; }

        public Client(int id, string name, string email, string plan): base(id, name, email)
        {
            SubscriptionPlan = plan;
        }
        public override string getDetails() => $"[Client] {Name}, Subscription: {SubscriptionPlan}";

        public void bookSession(string sessionName)
        {
            System.Console.WriteLine($"Client {Name} has made a reservation for  {sessionName}");
        }
    }
}
