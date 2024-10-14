
namespace HospitalAppointmentSystem.Models.Dtos.Response;

public sealed record DoctorResponseWithPatients(
    int Id,
    string Name,
    string PatientName,
    string BranchName
    );
