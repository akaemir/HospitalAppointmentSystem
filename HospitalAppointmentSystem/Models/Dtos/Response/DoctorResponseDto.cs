namespace HospitalAppointmentSystem.Models.Dtos.Response;

public class DoctorResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Enum'ın ismi olarak DTO'da dönecek
    public string BranchName { get; set; }
}
