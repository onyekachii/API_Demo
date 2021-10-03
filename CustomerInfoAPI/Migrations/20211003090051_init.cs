using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerInfoAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultPassword = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(38,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "DefaultPassword", "FirstName", "IsActive", "LastName", "Nationality", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 23, new DateTime(2021, 10, 3, 10, 0, 50, 641, DateTimeKind.Local).AddTicks(2706), "Kapitan", true, "Alex", true, "Ogubuike", "Nigerian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "DefaultPassword", "FirstName", "IsActive", "LastName", "Nationality", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 70, new DateTime(2021, 10, 3, 10, 0, 50, 641, DateTimeKind.Local).AddTicks(7333), "Kapitan", true, "Tochi", true, "Nwokolo", "Nigerian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CustomerId" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 123456789, 2000m, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a") });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CustomerId" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 123456789, 2000m, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811") });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CustomerId",
                table: "Accounts",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
