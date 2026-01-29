using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Entities
{
    public class Admin : User
    {
        public Admin(int id, string name, string email) : base(id, name, email){}

        public override string getDetails() => $"[Admin] {Name}, Permisiuni: System Maintenance";

        public void manageEquipment(string equipmentName, string status)
        {
            System.Console.WriteLine($"Admin {Name} , marked the {equipmentName} device as {status}");
        }
    }
}
