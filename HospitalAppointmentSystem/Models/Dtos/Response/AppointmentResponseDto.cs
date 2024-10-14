
namespace HospitalAppointmentSystem.Models.Dtos.Response;

public sealed record AppointmentResponseDto(
    string PatientName,
    DateTime AppointmentDate,
    int DoctorId
    );

