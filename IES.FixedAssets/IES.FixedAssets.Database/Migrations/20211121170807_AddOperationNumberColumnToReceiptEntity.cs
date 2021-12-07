using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class AddOperationNumberColumnToReceiptEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationNumber",
                table: "Receipts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationNumber",
                table: "Receipts");
        }
    }
}
