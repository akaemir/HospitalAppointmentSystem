using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Dtos.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<DoctorResponseDto> doctors = _doctorService.GetAll();
            return Ok(doctors);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            try
            {
                DoctorResponseDto doctor = _doctorService.GetById(id);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return NotFound("Aranan id bulunamadi!");
            }
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateDoctorRequest doctor)
        {
            try
            {
                if (doctor.Name == string.Empty)
                {
                    return BadRequest("Doktor ismi boş olmamalidir!");
                }
                var created = _doctorService.Add(doctor);
                return Ok(created);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpDelete("remove")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deleted = _doctorService.Delete(id);
                return Ok(deleted);

            }
            catch (Exception ex)
            {
                return NotFound("Silmek istediginiz id bulunamadi!");
            }
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateDoctorRequest updateDoctor)
        {
            try
            {
                if (updateDoctor.id < 1)
                {
                    return BadRequest("Gecerli bir id degeri giriniz!");
                }
                var updated = _doctorService.Update(updateDoctor);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
