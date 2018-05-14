using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;

namespace BusinessApp.Services
{
   public class AppointmentService:IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;

        }

       public List<Appointment> GetAppointmentByUserId(long userId)
       {
            return _appointmentRepository.GetAllRecords("SELECT * FROM [Appointment] WHERE ClientId = " + userId.ToString()).ToList();
        }

       public List<Appointment> GetAppointmentByDate(DateTime appointmentDate)
       {
            return _appointmentRepository.GetAllRecords("SELECT * FROM [Appointment] WHERE AppointmentDate = " + appointmentDate.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _appointmentRepository.Delete(id);
       }

       public void SaveOrUpdate(Appointment appointment)
       {
            _appointmentRepository.SaveOrUpdate(appointment);
       }

       public long Save(Appointment appointment)
       {
           return _appointmentRepository.Save(appointment);
       }

       public IList<Appointment> GetAllRecords()
       {
            return _appointmentRepository.GetAllRecords("SELECT * FROM [Appointment]");
        }

       public Appointment Get(long id)
       {
           return _appointmentRepository.Get(id);
       }
    }
}
