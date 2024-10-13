
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Doctor : Entity<int>
{

    public string Name { get; set; }
    public Branch Branch { get; set; }
}
