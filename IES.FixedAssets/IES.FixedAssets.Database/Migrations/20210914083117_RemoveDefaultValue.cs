using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class RemoveDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiptDate",
                table: "Receipts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 14, 12, 29, 53, 916, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEntry",
                table: "EntryJournals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 14, 12, 29, 53, 902, DateTimeKind.Local).AddTicks(6845));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiptDate",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 14, 12, 29, 53, 916, DateTimeKind.Local).AddTicks(243),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEntry",
                table: "EntryJournals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 14, 12, 29, 53, 902, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime));
        }
    }
}
