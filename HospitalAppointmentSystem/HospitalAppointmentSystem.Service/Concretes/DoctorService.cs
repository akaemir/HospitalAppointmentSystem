
using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.Service.Mapper;
namespace HospitalAppointmentSystem.Service.Concretes;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;
    private readonly DoctorMapper _doctorMapper;
    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper, DoctorMapper doctorMapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
        _doctorMapper = doctorMapper;
    }
    public Doctor Add(CreateDoctorRequest create)
    {
        Doctor doctor = _mapper.Map<Doctor>(create);
        Doctor createdDoctor = _doctorRepository.Add(doctor);
        return createdDoctor;
    }

    public Doctor? Delete(int id)
    {
        Doctor filtered = _doctorRepository.GetById(id);
        Doctor? doctor = _doctorRepository.Remove(filtered);
        return doctor;
    }

    public List<DoctorResponseDto> GetAll()
    {
        List<Doctor> doctors = _doctorRepository.GetAll();
        List<DoctorResponseDto> responses = _doctorMapper.ConvertToResponseList(doctors);
        return responses;
    }

    public DoctorResponseDto? GetById(int id)
    {
        Doctor doctor = _doctorRepository.GetById(id);
        DoctorResponseDto doctorResponseDto = _doctorMapper.ConvertToResponse(doctor);
        return doctorResponseDto;
    }

    public Doctor Update(UpdateDoctorRequest update)
    {
        var doctor = _mapper.Map<Doctor>(update);
        //Doctor updatedDoctor = _doctorMapper.ConvertUpdateEntity(update);
        Doctor updated = _doctorRepository.Update(doctor);
        return updated;
    }
}
