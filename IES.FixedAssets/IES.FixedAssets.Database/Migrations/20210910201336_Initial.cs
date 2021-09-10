using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IES.FixedAssets.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditAccountCharts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 4, nullable: false),
                    AccountName = table.Column<string>(maxLength: 100, nullable: false),
                    AccountType = table.Column<string>(maxLength: 100, nullable: false),
                    FirstSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    SecondSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    ThirdSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    Comment = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditAccountCharts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DebitAccountCharts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 4, nullable: false),
                    AccountName = table.Column<string>(maxLength: 100, nullable: false),
                    AccountType = table.Column<string>(maxLength: 100, nullable: false),
                    FirstSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    SecondSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    ThirdSubconto = table.Column<string>(maxLength: 4, nullable: true),
                    Comment = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitAccountCharts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FixedAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    BalancePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedAssets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProviderId = table.Column<Guid>(nullable: false),
                    Sum = table.Column<double>(nullable: false),
                    ReceiptDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 9, 11, 0, 13, 35, 778, DateTimeKind.Local).AddTicks(6704)),
                    OperationType = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ReceiptId = table.Column<Guid>(nullable: false),
                    FixedAssetId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Sum = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptTables_FixedAssets_FixedAssetId",
                        column: x => x.FixedAssetId,
                        principalTable: "FixedAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptTables_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntryJournals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DebitAccountId = table.Column<Guid>(nullable: false),
                    CreditAccountId = table.Column<Guid>(nullable: false),
                    ReceiptTableId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Sum = table.Column<double>(nullable: false),
                    DateEntry = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 9, 11, 0, 13, 35, 759, DateTimeKind.Local).AddTicks(6528))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryJournals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryJournals_CreditAccountCharts_CreditAccountId",
                        column: x => x.CreditAccountId,
                        principalTable: "CreditAccountCharts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryJournals_DebitAccountCharts_DebitAccountId",
                        column: x => x.DebitAccountId,
                        principalTable: "DebitAccountCharts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryJournals_ReceiptTables_ReceiptTableId",
                        column: x => x.ReceiptTableId,
                        principalTable: "ReceiptTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditAccountCharts_AccountName",
                table: "CreditAccountCharts",
                column: "AccountName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreditAccountCharts_AccountNumber",
                table: "CreditAccountCharts",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebitAccountCharts_AccountName",
                table: "DebitAccountCharts",
                column: "AccountName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebitAccountCharts_AccountNumber",
                table: "DebitAccountCharts",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntryJournals_CreditAccountId",
                table: "EntryJournals",
                column: "CreditAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryJournals_DebitAccountId",
                table: "EntryJournals",
                column: "DebitAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryJournals_ReceiptTableId",
                table: "EntryJournals",
                column: "ReceiptTableId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedAssets_Name",
                table: "FixedAssets",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Name",
                table: "Providers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ProviderId",
                table: "Receipts",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptTables_FixedAssetId",
                table: "ReceiptTables",
                column: "FixedAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptTables_ReceiptId",
                table: "ReceiptTables",
                column: "ReceiptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryJournals");

            migrationBuilder.DropTable(
                name: "CreditAccountCharts");

            migrationBuilder.DropTable(
                name: "DebitAccountCharts");

            migrationBuilder.DropTable(
                name: "ReceiptTables");

            migrationBuilder.DropTable(
                name: "FixedAssets");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
