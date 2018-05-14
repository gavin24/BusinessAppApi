using BusinessApp.Models;
using BusinessAppApi.Enums;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class NotificationMap : ClassMap<Notification>
    {
        public NotificationMap()
        {
            Table("[Notification]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.UserId).Column("UserId");
            Map(x => x.Header).Column("Header");
            Map(x => x.Body).Column("Body");
            Map(x => x.TimeSent).Column("TimeSent");
            Map(x => x.NotType).Column("NotType").CustomType<NotficationType>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

        }
    }
}