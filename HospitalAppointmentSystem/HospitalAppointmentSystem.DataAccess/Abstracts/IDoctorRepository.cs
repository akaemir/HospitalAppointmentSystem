using Core.Entities;
using Core.Repositories;
using HospitalAppointmentSystem.Models.Dtos.Request;
using HospitalAppointmentSystem.Models.Entities;
using System.Security.Cryptography;
namespace HospitalAppointmentSystem.DataAccess.Abstracts;

public interface IDoctorRepository : IRepository<Doctor, int>
{
    //List<Doctor> GetAllWithPatients();
    //Doctor? GetByIdWithPatients(int id);
}
