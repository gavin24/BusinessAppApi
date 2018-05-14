using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Table("[Products]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.Name).Column("Name");
            Map(x => x.PriceAmount).Column("PriceAmount");
            Map(x => x.CatergoryId).Column("CatergoryId");
            Map(x => x.Description).Column("Description");
            Map(x => x.Quantity).Column("Quantity");
            Map(x => x.ProductImageId).Column("ProductImageId");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}