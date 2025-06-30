using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class MobileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ram = table.Column<byte>(type: "tinyint", nullable: false),
                    Battery = table.Column<short>(type: "smallint", maxLength: 15, nullable: false),
                    ChargerInBox = table.Column<bool>(type: "bit", nullable: false),
                    LaunchOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
