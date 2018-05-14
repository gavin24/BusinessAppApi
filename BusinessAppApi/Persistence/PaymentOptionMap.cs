using BusinessApp.Models;
using BusinessAppApi.Enums;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class PaymentOptionMap : ClassMap<PaymentOption>
    {
        public PaymentOptionMap()
        {
            Table("[PaymentOption]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.PayType).Column("PayType").CustomType<PaymentType>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
    }
    }
}