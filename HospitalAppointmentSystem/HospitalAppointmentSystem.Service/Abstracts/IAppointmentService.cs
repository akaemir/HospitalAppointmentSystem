
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IAppointmentService
{
    List<AppointmentResponseDto> GetAll();
    AppointmentResponseDto? GetById(Guid id);
    Appointment Add(CreateAppointmentRequest create);
    Appointment Update(UpdateAppointmentRequest update);
    Appointment? Delete(Guid id);
}
