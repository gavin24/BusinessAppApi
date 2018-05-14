using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class PriceMap : ClassMap<Price>
    {
        public PriceMap()
        {
            Table("[Price]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.Currency).Column("Currency");
            Map(x => x.Amount).Column("Amount");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}