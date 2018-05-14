using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class QuotesMap : ClassMap<Quotes>
    {
        public QuotesMap()
        {
            Table("[Quotes]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.Body).Column("Body");
            Map(x => x.DateSent).Column("DateSent");
            Map(x => x.UserId).Column("UserId");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
 
    }
    }
}