
using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateDoctorRequest, Doctor>();
        CreateMap<DoctorResponseDto, Doctor>();
        CreateMap<UpdateDoctorRequest, Doctor>();

        CreateMap<CreateAppointmentRequest, Appointment>();
        CreateMap<AppointmentResponseDto, Appointment>();
        CreateMap<UpdateAppointmentRequest, Appointment>();
    }
}
