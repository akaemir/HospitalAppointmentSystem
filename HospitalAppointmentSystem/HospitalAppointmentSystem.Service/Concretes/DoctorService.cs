
using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using HospitalAppointmentSystem.DataAccess.Abstracts;
namespace HospitalAppointmentSystem.Service.Concretes;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;
    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    public Doctor Add(CreateDoctorRequest create)
    {
        Doctor doctor = _mapper.Map<Doctor>(create);
        Doctor createdDoctor = _doctorRepository.Add(doctor);
        return createdDoctor;
    }

    public Doctor Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<DoctorResponseDto> GetAll()
    {
        List<Doctor> doctors = _doctorRepository.GetAll();
        List<DoctorResponseDto> responses = _mapper.ConvertToResponse();
        return responses;
    }

    public DoctorResponseDto GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Doctor Update(UpdateDoctorRequest update)
    {
        throw new NotImplementedException();
    }
}
