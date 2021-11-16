using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarketChart.Migrations
{
    public partial class migrt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "company_name",
                table: "IPODetails");

            migrationBuilder.AddColumn<string>(
                name: "companyid",
                table: "StockPrices",
                type: "Char(5)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "companyid",
                table: "IPODetails",
                type: "Char(5)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPrices_companyid",
                table: "StockPrices",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_IPODetails_companyid",
                table: "IPODetails",
                column: "companyid");

            migrationBuilder.AddForeignKey(
                name: "FK_IPODetails_Companies_companyid",
                table: "IPODetails",
                column: "companyid",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrices_Companies_companyid",
                table: "StockPrices",
                column: "companyid",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPODetails_Companies_companyid",
                table: "IPODetails");

            migrationBuilder.DropForeignKey(
                name: "FK_StockPrices_Companies_companyid",
                table: "StockPrices");

            migrationBuilder.DropIndex(
                name: "IX_StockPrices_companyid",
                table: "StockPrices");

            migrationBuilder.DropIndex(
                name: "IX_IPODetails_companyid",
                table: "IPODetails");

            migrationBuilder.DropColumn(
                name: "companyid",
                table: "StockPrices");

            migrationBuilder.DropColumn(
                name: "companyid",
                table: "IPODetails");

            migrationBuilder.AddColumn<string>(
                name: "company_name",
                table: "IPODetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
