using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class AddNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleId",
                table: "Receipts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Subdivision",
                table: "Receipts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Responsibles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Fio = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropColumn(
                name: "ResponsibleId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "Subdivision",
                table: "Receipts");
        }
    }
}
