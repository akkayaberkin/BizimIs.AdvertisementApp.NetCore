using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizimIs.AdvertisementApp.Entities;

namespace BizimIs.AdvertisementApp.DataAccess.Configurations
{
    public class AdvertisementAppUserStatusConfiguration : IEntityTypeConfiguration<AdvertisementAppUserStatus>
    {
        public void Configure(EntityTypeBuilder<AdvertisementAppUserStatus> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300).IsRequired();
            builder.HasData(new AdvertisementAppUserStatus[]
            {
                new()
                {
                    Definition="Basvurdu",
                    Id=1,
                },
                new()
                {
                    Definition= "Mulakat",
                    Id=2
                },
                new()
                {
                    Definition= "Olumsuz",
                    Id=3
                }
            });
        }
    }
}
