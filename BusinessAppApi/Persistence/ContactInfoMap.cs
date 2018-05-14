using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class ContactInfoMap : ClassMap<ContactInfo>
    {
        public ContactInfoMap()
        {
            Table("[ContactInfo]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.Email).Column("Email");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            Map(x => x.SecondaryEmail).Column("SecondaryEmail");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}