﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BizimIs.AdvertisementApp.DataAccess.Contexts;

namespace BizimIs.AdvertisementApp.DataAccess.Migrations
{
    [DbContext(typeof(AdvertisementContext))]
    partial class AdvertisementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AdvertisementAppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementAppUserStatusId")
                        .HasColumnType("int");

                    b.Property<int>("AdvertisementId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("CvPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MilitaryStatusId")
                        .HasColumnType("int");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementAppUserStatusId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MilitaryStatusId");

                    b.HasIndex("AdvertisementId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AdvertisementAppUsers");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AdvertisementAppUserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AdvertisementAppUserStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Basvurdu"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Mulakat"
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Olumsuz"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Member"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "Berkin",
                            GenderId = 1,
                            Password = "123",
                            PhoneNumber = "500-789-65-43",
                            Surname = "Akkaya",
                            Username = "berkinakkaya"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AppRoleId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppRoleId = 1,
                            AppUserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AppRoleId = 2,
                            AppUserId = 1
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Erkek"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Kadın"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.MilitaryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("MilitaryStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Yapildi"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Tecilli"
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Muaf"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.ProvidedService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("ProvidedServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 4, 11, 18, 27, 51, 247, DateTimeKind.Local).AddTicks(4099),
                            Description = "Açıklama - 1",
                            ImagePath = "DashboardPhotos\\1.jpg",
                            Title = "Selim Bey"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3768),
                            Description = "Açıklama - 2",
                            ImagePath = "DashboardPhotos\\2.jpg",
                            Title = "Yavuz Bey"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3786),
                            Description = "Açıklama - 3",
                            ImagePath = "DashboardPhotos\\3.jpg",
                            Title = "Süleyman Bey"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3788),
                            Description = "Açıklama - 4",
                            ImagePath = "DashboardPhotos\\4.jpg",
                            Title = "Fatih Bey"
                        });
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AdvertisementAppUser", b =>
                {
                    b.HasOne("BizimIs.AdvertisementApp.Entities.AdvertisementAppUserStatus", "AdvertisementAppUserStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementAppUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimIs.AdvertisementApp.Entities.Advertisement", "Advertisement")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimIs.AdvertisementApp.Entities.AppUser", "AppUser")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimIs.AdvertisementApp.Entities.MilitaryStatus", "MilitaryStatus")
                        .WithMany("AdvertisementAppUsers")
                        .HasForeignKey("MilitaryStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advertisement");

                    b.Navigation("AdvertisementAppUserStatus");

                    b.Navigation("AppUser");

                    b.Navigation("MilitaryStatus");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppUser", b =>
                {
                    b.HasOne("BizimIs.AdvertisementApp.Entities.Gender", "Gender")
                        .WithMany("AppUsers")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppUserRole", b =>
                {
                    b.HasOne("BizimIs.AdvertisementApp.Entities.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimIs.AdvertisementApp.Entities.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.Advertisement", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AdvertisementAppUserStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.AppUser", b =>
                {
                    b.Navigation("AdvertisementAppUsers");

                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.Gender", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("BizimIs.AdvertisementApp.Entities.MilitaryStatus", b =>
                {
                    b.Navigation("AdvertisementAppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
