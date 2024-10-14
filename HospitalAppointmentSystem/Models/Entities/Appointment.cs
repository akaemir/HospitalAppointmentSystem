
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentSystem.Models.Entities;

public class Appointment : Entity<Guid>
{
    [Required(ErrorMessage = "Hasta ismi boş olamaz")]
    public string PatientName { get; set; }
    public DateTime AppointmentDate { get; set; }
    [Required(ErrorMessage = "Randevu alınacak doktor id'si belirtilmek zorundadır!")]
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}
