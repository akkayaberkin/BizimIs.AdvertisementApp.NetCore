using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimIs.AdvertisementApp.DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProvidedServices",
                columns: new[] { "Id", "CreatedDate", "Description", "ImagePath", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 11, 18, 27, 51, 247, DateTimeKind.Local).AddTicks(4099), "Açıklama - 1", "DashboardPhotos\\1.jpg", "Selim Bey" },
                    { 2, new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3768), "Açıklama - 2", "DashboardPhotos\\2.jpg", "Yavuz Bey" },
                    { 3, new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3786), "Açıklama - 3", "DashboardPhotos\\3.jpg", "Süleyman Bey" },
                    { 4, new DateTime(2022, 4, 11, 18, 27, 51, 248, DateTimeKind.Local).AddTicks(3788), "Açıklama - 4", "DashboardPhotos\\4.jpg", "Fatih Bey" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProvidedServices",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
