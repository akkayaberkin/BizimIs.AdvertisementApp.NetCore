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
    public class MilitaryStatusConfiguration : IEntityTypeConfiguration<MilitaryStatus>
    {
        public void Configure(EntityTypeBuilder<MilitaryStatus> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300).IsRequired();
            builder.HasData(new MilitaryStatus[]
                { new MilitaryStatus{Id=1, Definition = "Yapildi" },
                new MilitaryStatus{  Id=2 ,Definition = "Tecilli" },
                new MilitaryStatus{  Id=3 ,Definition = "Muaf" }});
        }

    }
}
