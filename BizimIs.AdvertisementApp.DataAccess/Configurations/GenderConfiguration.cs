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
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300).IsRequired();

            builder.HasData(new Gender[] {
            new Gender()
            {
                Id=1,
                Definition="Erkek"
            },
            new Gender()
            {
                Id = 2,
                Definition = "Kadın"
            }});
        }
    }
}
