
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Models.Dtos.Request;

public sealed record CreateDoctorRequest(string Name,Branch Branch);
