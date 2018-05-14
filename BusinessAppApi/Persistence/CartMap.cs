using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Table("[Cart]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.CartCreated).Column("CartCreated");
            Map(x => x.ItemAmount).Column("ItemAmount");
            Map(x => x.Total).Column("Total");       
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
 
    }
    }
}