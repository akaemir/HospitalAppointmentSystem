namespace HospitalAppointmentSystem.Models.Dtos.Response;

public sealed record DoctorResponseDto
(
    int Id,
    string Name,
    // Enum'ın ismi olarak DTO'da dönecek
    string BranchName
);
