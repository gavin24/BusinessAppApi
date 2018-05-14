using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Table("[Location]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.CoOrdinates).Column("CoOrdinates");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.LocationName).Column("LocationName");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}