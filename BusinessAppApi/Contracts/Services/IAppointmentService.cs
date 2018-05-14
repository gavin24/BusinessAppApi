using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IAppointmentService
    {
        List<Appointment> GetAppointmentByUserId(long userId);
        List<Appointment> GetAppointmentByDate(DateTime appointmentDate);
        void Delete(long id);
        void SaveOrUpdate(Appointment appointment);
        long Save(Appointment appointment);
        IList<Appointment> GetAllRecords();
        Appointment Get(long id);
    }
}
