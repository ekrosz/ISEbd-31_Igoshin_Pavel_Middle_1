using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class AddColumnsEntryJournalEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditFirstSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditSecondSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditThirdSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebitFirstSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebitSecondSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebitThirdSubconto",
                table: "EntryJournals",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ThirdSubconto",
                table: "DebitAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondSubconto",
                table: "DebitAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstSubconto",
                table: "DebitAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "DebitAccountCharts",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ThirdSubconto",
                table: "CreditAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondSubconto",
                table: "CreditAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstSubconto",
                table: "CreditAccountCharts",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "CreditAccountCharts",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditFirstSubconto",
                table: "EntryJournals");

            migrationBuilder.DropColumn(
                name: "CreditSecondSubconto",
                table: "EntryJournals");

            migrationBuilder.DropColumn(
                name: "CreditThirdSubconto",
                table: "EntryJournals");

            migrationBuilder.DropColumn(
                name: "DebitFirstSubconto",
                table: "EntryJournals");

            migrationBuilder.DropColumn(
                name: "DebitSecondSubconto",
                table: "EntryJournals");

            migrationBuilder.DropColumn(
                name: "DebitThirdSubconto",
                table: "EntryJournals");

            migrationBuilder.AlterColumn<string>(
                name: "ThirdSubconto",
                table: "DebitAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondSubconto",
                table: "DebitAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstSubconto",
                table: "DebitAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "DebitAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ThirdSubconto",
                table: "CreditAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondSubconto",
                table: "CreditAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstSubconto",
                table: "CreditAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "CreditAccountCharts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
