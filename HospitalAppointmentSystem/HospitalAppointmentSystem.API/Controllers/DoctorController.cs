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
            DoctorResponseDto doctor = _doctorService.GetById(id);
            return Ok(doctor);
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateDoctorRequest doctor)
        {
            var created = _doctorService.Add(doctor);
            return Ok(created);
        }
        [HttpDelete("remove")]
        public IActionResult Delete(int id) 
        {
            var deleted = _doctorService.Delete(id);
            return Ok(deleted);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateDoctorRequest updateDoctor)
        {
            var updated = _doctorService.Update(updateDoctor);
            return Ok(updated);
        }
    }
}
