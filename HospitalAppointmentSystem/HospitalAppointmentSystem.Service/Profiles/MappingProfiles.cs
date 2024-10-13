
using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateDoctorRequest, Doctor>();
    }
}
