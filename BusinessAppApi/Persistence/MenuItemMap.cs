using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class MenuItemMap : ClassMap<MenuItem>
    {
        public MenuItemMap()
        {
            Table("[MenuItem]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.OrderNumber).Column("OrderNumber");
            Map(x => x.Name).Column("Name");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
    
    }
    }
}