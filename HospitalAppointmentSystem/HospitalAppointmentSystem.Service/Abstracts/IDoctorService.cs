using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IDoctorService
{
    List<DoctorResponseDto> GetAll();
    DoctorResponseDto GetById(int id);
    Doctor Add(CreateDoctorRequest create);
    Doctor Update(UpdateDoctorRequest update);
    Doctor Delete(int id);
}
