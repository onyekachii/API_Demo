using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Models.Account>
    {
        public void Configure(EntityTypeBuilder<Models.Account> builder)
        {
            builder.HasData
            (
            new Models.Account
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                AccountNumber = 123456789,
                Balance = 2000,
                CustomerId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")             
                
            },
            new Models.Account
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                AccountNumber = 123456789,
                Balance = 2000,
                CustomerId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")                
            }
            );
        }
    }
}
