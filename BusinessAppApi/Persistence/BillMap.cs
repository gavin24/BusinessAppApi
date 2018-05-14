using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class BillMap : ClassMap<Bill>
    {
        public BillMap()
        {
            Table("[vTouchComponentStage]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.BillSent).Column("BillSent");
            Map(x => x.Total).Column("Total");
            Map(x => x.OrderId).Column("OrderId");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at"); 
    
    }
    }
}