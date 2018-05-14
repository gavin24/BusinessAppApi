using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class CategoriesMap : ClassMap<Categories>
    {
        public CategoriesMap()
        {
            Table("[vTouchComponentStage]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

        }
    }
}