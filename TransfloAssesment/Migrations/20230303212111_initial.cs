using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TransfloAssesment.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modificationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Email", "creationDate", "deletedDate", "firstName", "isDeleted", "lastName", "modificationDate", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "Ramadan@gmail.com", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Ramadan1", false, "Essam", null, "+128987873" },
                    { 2, "Ramadan2@gmail.com", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Ramadan2", false, "Essam", null, "+1028987873" },
                    { 3, "Ramadan3@gmail.com", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Ramadan3", false, "Essam", null, "+01028987873" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
