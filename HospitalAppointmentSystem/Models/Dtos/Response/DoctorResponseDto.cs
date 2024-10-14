namespace HospitalAppointmentSystem.Models.Dtos.Response;

public sealed record DoctorResponseDto
(
    int Id,
    string Name,
    // Branch id ye eş gelen name gosterilecek
    string BranchName
);
