
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Mapper;

public class DoctorMapper
{
    public Doctor ConvertToEntity(CreateDoctorRequest request)
    {
        return new Doctor
        {
            Name = request.Name,
            Branch = request.Branch,
        };
    }
    public DoctorResponseDto ConvertToResponse(Doctor doctor)
    {
        if (doctor is null)
        {
            throw new Exception("Doktor bulunamadi!");
        }
        return new DoctorResponseDto(
            Id: doctor.Id,
            Name: doctor.Name,
            BranchName: doctor.Branch.ToString()
            );
    }
    public List<DoctorResponseDto> ConvertToResponseList(List<Doctor> doctors)
    {
        return doctors.Select(x => ConvertToResponse(x)).ToList();
    }
    public Doctor ConvertUpdateEntity(UpdateDoctorRequest request)
    {
        return new Doctor
        {
            Name = request.Name,
            Id = request.id,
            Branch = request.Branch,
        };
    }
}
