
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Doctor : Entity<int>
{
    public Doctor()
    {
        Name = string.Empty;
    }
    public string Name { get; set; }
    public Branch Branch { get; set; }
}
