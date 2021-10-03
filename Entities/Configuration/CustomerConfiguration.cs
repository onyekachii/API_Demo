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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
            (
            new Customer
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                FirstName = "Alex",
                LastName = "Ogubuike",
                Age = 23,
                Nationality = "Nigerian",
                CreatedAt = DateTime.Now,
                CreatedBy = "Kapitan",
                DefaultPassword = true,
                IsActive = true
            },
            new Customer
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                FirstName = "Tochi",
                LastName = "Nwokolo",
                Age = 70,
                Nationality = "Nigerian",
                CreatedAt = DateTime.Now,
                CreatedBy = "Kapitan",
                DefaultPassword = true,
                IsActive = true
            }
            );
        }
    }
}