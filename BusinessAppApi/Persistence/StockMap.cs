using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class StockMap : ClassMap<Stock>
    {
        public StockMap()
        {
            Table("[Stock]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ProductId).Column("ProductId");
            Map(x => x.Amount).Column("Amount");
            Map(x => x.DateAccepted).Column("DateAccepted");
            Map(x => x.Supplier).Column("Supplier");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}