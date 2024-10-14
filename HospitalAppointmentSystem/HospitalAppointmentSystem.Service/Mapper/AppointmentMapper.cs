
using Core.Exceptions;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Mapper;

public class AppointmentMapper
{
    public Appointment ConvertToEntity(CreateAppointmentRequest request)
    {
        return new Appointment
        {
            DoctorId = request.DoctorId,
            PatientName = request.PatientName,
        };
    }
    public AppointmentResponseDto ConvertToResponse(Appointment appointment)
    {
        if (appointment is null)
        {
            throw new NotFoundException("Randevu bulunamadı");
        }
        return new AppointmentResponseDto(
            PatientName: appointment.PatientName,
            AppointmentDate: appointment.AppointmentDate,
            DoctorId: appointment.DoctorId
            );
    }
    public List<AppointmentResponseDto> ConvertToResponseList(List<Appointment> appointments)
    {
        return appointments.Select(x => ConvertToResponse(x)).ToList();
    }
    public Appointment ConvertUpdateEntity(UpdateAppointmentRequest request)
    {
        return new Appointment
        {
            Id = request.appointmentId,
            AppointmentDate = request.AppointmentDate,
            DoctorId = request.DoctorId,
            PatientName = request.PatientName
        };
    }
}
