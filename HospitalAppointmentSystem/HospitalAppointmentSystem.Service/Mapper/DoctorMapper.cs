
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using static HospitalAppointmentSystem.Models.Entities.Doctor;

namespace HospitalAppointmentSystem.Service.Mapper;

public class DoctorMapper
{
    public Doctor ConvertToEntity(CreateDoctorRequest request)
    {
        return new Doctor
        {
            
        };
    }
}
