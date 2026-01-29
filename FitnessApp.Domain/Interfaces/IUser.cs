using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        string Name { get; }
        string getDetails();
    }
}
