
namespace HospitalAppointmentSystem.Models.Dtos.Request;

public record UpdateAppointmentRequest(
    Guid appointmentId,
    string PatientName,
    DateTime AppointmentDate,
    int DoctorId
    );
