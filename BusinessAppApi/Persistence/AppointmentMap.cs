using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class AppointmentMap : ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Table("[Appointment]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.AppointmentDate).Column("AppointmentDate");
            Map(x => x.StartTime).Column("StartTime");
            Map(x => x.EndTime).Column("EndTime");
            Map(x => x.AppointmentUserId).Column("AppointmentUserId");
            Map(x => x.Notes).Column("Notes");    
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
 


    }
    }
}