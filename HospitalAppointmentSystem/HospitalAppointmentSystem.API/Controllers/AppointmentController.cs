using Core.Entities;
using Core.Exceptions;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using HospitalAppointmentSystem.Service.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HospitalAppointmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {

            List<AppointmentResponseDto> appointments = _appointmentService.GetAll();
            return Ok(appointments);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                AppointmentResponseDto appointment = _appointmentService.GetById(id);
                return Ok(appointment);
            }
            catch (Exception ex)
            {
                return NotFound("Aradığınız id bulunamadi!");
            }

            //try
            //{
            //    AppointmentResponseDto appointment = _appointmentService.GetById(id);
            //    return Ok(appointment);
            //}
            //catch (NotFoundException ex)
            //{
            //    return NotFound(new ReturnModel<AppointmentResponseDto?>
            //    {
            //        Success = false,
            //        Data = null,
            //        Message = ex.Message,
            //        StatusCode = HttpStatusCode.NotFound
            //    });
            //}
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateAppointmentRequest appointment)
        {
            DateTime allowAppointmentDate = DateTime.Today.AddDays(3);
            try
            {
                if (appointment.PatientName == string.Empty || appointment.PatientName == "string")
                {
                    return BadRequest("Hasta ismi bos olmamali!");
                }
                else if (appointment.DoctorId < 1)
                {
                    return BadRequest("Randevu almak istediginiz doktoru secin");
                }
                else if (appointment.AppointmentDate <= allowAppointmentDate)
                {
                    return BadRequest($"En erken su tarihte randevu alabilirsin: {allowAppointmentDate}");
                }
                var created = _appointmentService.Add(appointment);
                return Ok(created);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            //try
            //{
            //    var created = _appointmentService.Add(appointment);
            //    return Ok(created);
            //}
            //catch (ValidationException ex)
            //{
            //    return BadRequest(new ReturnModel<Appointment>
            //    {
            //        Success = false,
            //        Data = null,
            //        Message = ex.Message,
            //        StatusCode = HttpStatusCode.BadRequest
            //    });
            //}
        }
        [HttpDelete("remove")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var deleted = _appointmentService.Delete(id);
                return Ok(deleted);
            }
            catch (Exception ex)
            {
                return NotFound("Silmek istediginiz id bulunamadi");
            }
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateAppointmentRequest updateAppointment)
        {
            try
            {
                if (updateAppointment.appointmentId == Guid.Empty)
                {
                    return BadRequest();
                }
                var updated = _appointmentService.Update(updateAppointment);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
