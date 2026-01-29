using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Domain.Interfaces
{
    public interface ISchedulable
    {
         void setAvailability(string timeSlot);
    }
}
