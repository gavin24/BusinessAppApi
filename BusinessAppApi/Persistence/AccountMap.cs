using BusinessApp.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessAppApi.Persistence
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Table("Account");
            Id(x => x.Id).GeneratedBy.Guid().Column("Id");
            Map(x => x.ClientId).Column("ClientId");
            Map(x => x.AccountName).Column("AccountName");
      
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

        }
    }
}