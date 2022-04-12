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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Username).HasMaxLength(300).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Gender).WithMany(x => x.AppUsers).HasForeignKey(x => x.GenderId);

            

            builder.HasData(new AppUser()
            {
                Id = 1,
                Firstname = "Berkin",
                Surname = "Akkaya",
                Username = "berkinakkaya",
                Password = "123",
                PhoneNumber = "500-789-65-43",
                GenderId = 1

            });
        }
    }
}
