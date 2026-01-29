using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Interfaces
{
    public interface IBookable
    {
       void bookSession(string sessionName);
    }
}
