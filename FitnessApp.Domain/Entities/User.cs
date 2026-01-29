using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Entities
{
    public abstract class User
    {
        public int Id { get; protected set; }

        public string Name { get; protected set; }
        public string Email { get; protected set; }

        protected User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public abstract string getDetails();
     
    }
}
