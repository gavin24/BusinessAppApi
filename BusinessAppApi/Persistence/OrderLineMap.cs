using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class OrderLineMap : ClassMap<OrderLine>
    {
        public OrderLineMap()
        {
            Table("[OrderLine]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.OrderNumber).Column("OrderNumber");
            Map(x => x.ClientNumber).Column("ClientNumber");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.ProductId).Column("ProductId");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}