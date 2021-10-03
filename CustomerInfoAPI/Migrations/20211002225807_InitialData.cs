using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerInfoAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "DefaultPassword", "FirstName", "IsActive", "LastName", "Nationality", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 23, new DateTime(2021, 10, 2, 23, 58, 5, 291, DateTimeKind.Local).AddTicks(4475), "Kapitan", true, "Alex", true, "Ogubuike", "Nigerian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "DefaultPassword", "FirstName", "IsActive", "LastName", "Nationality", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 70, new DateTime(2021, 10, 2, 23, 58, 5, 291, DateTimeKind.Local).AddTicks(7651), "Kapitan", true, "Tochi", true, "Nwokolo", "Nigerian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));
        }
    }
}
