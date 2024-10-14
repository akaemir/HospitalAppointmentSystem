
using Core.Entities;
using Core.Repositories;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Contexts;
using HospitalAppointmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace HospitalAppointmentSystem.DataAccess.Concretes;

public class EfDoctorRepository : EfRepositoryBase<BaseDbContext, Doctor, int>, IDoctorRepository
{
    public EfDoctorRepository(BaseDbContext context) : base(context)
    {
    }

    //public List<Doctor> GetAllWithPatients()
    //{
    //    return Context.Set<Doctor>()
    //        .Include(x => x.Patients)
    //        .ToList();
    //}

    //public Doctor? GetByIdWithPatients(int id)
    //{
    //    return Context.Set<Doctor>()
    //        .Include(x => x.Patients)
    //        .FirstOrDefault(d => d.Id == id);
    //}
}
