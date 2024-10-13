
using Core.Repositories;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Contexts;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.DataAccess.Concretes;

public class EfAppointmentRepository : EfRepositoryBase<BaseDbContext,Appointment,Guid>, IAppointmentRepository
{
    public EfAppointmentRepository(BaseDbContext context) : base(context)
    {
        
    }
}
