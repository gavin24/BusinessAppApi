using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class ImagesMap : ClassMap<Images>
    {
        public ImagesMap()
        {
            Table("[Images]");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.ImageBytes).Column("ImageBytes");
            Map(x => x.ImageName).Column("ImageName");
            Map(x => x.ImageExtension).Column("ImageExtension");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

    }
    }
}