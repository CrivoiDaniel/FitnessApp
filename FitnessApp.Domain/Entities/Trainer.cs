using FitnessApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Entities
{
    public class Trainer : User, ISchedulable
    {
        public string Specialty {  get; set; }
        public Trainer(int id, string name, string email, string specialty) :base(id, name, email)
        {
            Specialty = specialty;
        }

        public override string getDetails() => $"Trainer {Name}, Speciality: {Specialty}";
        public void setAvailability(string timeSlot)
        {
            System.Console.WriteLine($"Trainer {Name}, is now available at {timeSlot} ");
        }
    }
}
