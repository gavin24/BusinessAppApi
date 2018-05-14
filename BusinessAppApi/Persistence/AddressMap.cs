using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("[Address]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.Line1).Column("Line1");
            Map(x => x.Line2).Column("Line2");
            Map(x => x.Line3).Column("Line3");
            Map(x => x.Line4).Column("Line4");
            Map(x => x.Line5).Column("Line5");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
   
    }
    }
}