
namespace HospitalAppointmentSystem.Models.Dtos.Request;

public sealed record CreateAppointmentRequest(
    string PatientName,
    DateTime AppointmentDate,
    int DoctorId
    );
