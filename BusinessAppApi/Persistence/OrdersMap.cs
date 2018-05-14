using BusinessApp.Models;
using BusinessAppApi.Enums;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class OrdersMap : ClassMap<Orders>
    {
        public OrdersMap()
        {
            Table("[Orders]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.OrderNumber).Column("OrderNumber");
            Map(x => x.OrderDate).Column("OrderDate");
            Map(x => x.OrderStat).Column("OrderStat").CustomType<OrderStatus>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}