
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentSystem.Models.Entities;

public class Doctor : Entity<int>
{
    public Doctor()
    {
        Name = string.Empty;
    }
    [Required(ErrorMessage = "Doktor ismi boş bırakılamaz!")]
    public string Name { get; set; }
    public Branch Branch { get; set; }
    //public List<Patients> Patients { get; set; }
}
