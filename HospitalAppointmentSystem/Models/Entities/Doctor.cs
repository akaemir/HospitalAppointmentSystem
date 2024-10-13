
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Doctor : Entity<int>
{
    public enum Branch
    {
        KBB,
        Ortopedi
    }
    public string Name { get; set; }
    public Branch Branchs { get; set; }
}
