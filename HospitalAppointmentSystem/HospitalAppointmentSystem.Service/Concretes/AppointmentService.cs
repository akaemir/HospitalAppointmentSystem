
using AutoMapper;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Concretes;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using HospitalAppointmentSystem.Service.Mapper;

namespace HospitalAppointmentSystem.Service.Concretes;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMapper _mapper;
    private readonly AppointmentMapper _appointmentMapper;
    public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper, AppointmentMapper appointmentMapper)
    {
        _appointmentMapper = appointmentMapper;
        _appointmentRepository = appointmentRepository;
        _mapper = mapper;
    }
    public Appointment Add(CreateAppointmentRequest create)
    {
        //DateTime allowAppointmentDate = DateTime.Now.AddDays(3);
        //if (create.AppointmentDate <= allowAppointmentDate)
        //{
        //    throw new Exception("En erken 3 gun icerisinde randevu alabilirsiniz");
        //}
        Appointment appointment = _mapper.Map<Appointment>(create);
        Appointment createdAppointment = _appointmentRepository.Add(appointment);
        return createdAppointment;
    }

    public Appointment? Delete(Guid id)
    {
        Appointment filtered = _appointmentRepository.GetById(id);
        Appointment? appointment = _appointmentRepository.Remove(filtered);
        return appointment;
    }

    public List<AppointmentResponseDto> GetAll()
    {
        List<Appointment> appointment = _appointmentRepository.GetAll();
        List<AppointmentResponseDto> responses = _appointmentMapper.ConvertToResponseList(appointment);
        return responses;
    }

    public AppointmentResponseDto? GetById(Guid id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);
        AppointmentResponseDto appointmentResponseDto = _appointmentMapper.ConvertToResponse(appointment);
        return appointmentResponseDto;
    }

    public Appointment Update(UpdateAppointmentRequest update)
    {
        var appointment = _mapper.Map<Appointment>(update);
        Appointment updated = _appointmentRepository.Update(appointment);
        return updated;
    }
}
