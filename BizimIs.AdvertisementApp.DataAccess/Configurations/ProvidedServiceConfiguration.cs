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
    public class ProvidedServiceConfiguration : IEntityTypeConfiguration<ProvidedService>
    {
        public void Configure(EntityTypeBuilder<ProvidedService> builder)
        {
            builder.Property(x => x.Description).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(300).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");

            builder.HasData(new ProvidedService[] {
            new ProvidedService() { Id=1,Title="Selim Bey",Description = "Açıklama - 1",ImagePath = @"DashboardPhotos\1.jpg",CreatedDate =DateTime.Now},
            new ProvidedService() { Id=2,Title="Yavuz Bey",Description = "Açıklama - 2",ImagePath = @"DashboardPhotos\2.jpg",CreatedDate =DateTime.Now},
            new ProvidedService() { Id=3,Title="Süleyman Bey",Description = "Açıklama - 3",ImagePath = @"DashboardPhotos\3.jpg",CreatedDate =DateTime.Now},
            new ProvidedService() { Id=4,Title="Fatih Bey",Description = "Açıklama - 4",ImagePath = @"DashboardPhotos\4.jpg",CreatedDate =DateTime.Now}});
        }
    }
}



