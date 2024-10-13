
using static HospitalAppointmentSystem.Models.Entities.Doctor;

namespace HospitalAppointmentSystem.Models.Dtos.Request;

public sealed record UpdateDoctorRequest(int id,string Name,string BranchName);

