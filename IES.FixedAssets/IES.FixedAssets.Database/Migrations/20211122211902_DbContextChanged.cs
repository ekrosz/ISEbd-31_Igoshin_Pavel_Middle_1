using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class DbContextChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subdivision",
                table: "Receipts");

            migrationBuilder.AddColumn<Guid>(
                name: "SubdivisionId",
                table: "Receipts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ResponsibleId",
                table: "Receipts",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_SubdivisionId",
                table: "Receipts",
                column: "SubdivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Responsibles_ResponsibleId",
                table: "Receipts",
                column: "ResponsibleId",
                principalTable: "Responsibles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Subdivisions_SubdivisionId",
                table: "Receipts",
                column: "SubdivisionId",
                principalTable: "Subdivisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Responsibles_ResponsibleId",
                table: "Receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Subdivisions_SubdivisionId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_ResponsibleId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_SubdivisionId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "SubdivisionId",
                table: "Receipts");

            migrationBuilder.AddColumn<Guid>(
                name: "Subdivision",
                table: "Receipts",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
