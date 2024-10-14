
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Patients : Entity<int>
{
    public string Name { get; set; }
}
