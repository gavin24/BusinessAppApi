using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
     
        public AppointmentRepository(ISession session) : base(session)
       {
          
        }

       public List<Appointment> GetAppointmentByUserId(long userId)
       {
           throw new NotImplementedException();
       }

       public List<Appointment> GetAppointmentByDate(DateTime appointmentDate)
       {
           throw new NotImplementedException();
       }
    }
}
