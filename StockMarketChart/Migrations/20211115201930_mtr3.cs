using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarketChart.Migrations
{
    public partial class mtr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "stockExchangeid",
                table: "StockPrices",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPrices_stockExchangeid",
                table: "StockPrices",
                column: "stockExchangeid");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrices_StockExchanges_stockExchangeid",
                table: "StockPrices",
                column: "stockExchangeid",
                principalTable: "StockExchanges",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPrices_StockExchanges_stockExchangeid",
                table: "StockPrices");

            migrationBuilder.DropIndex(
                name: "IX_StockPrices_stockExchangeid",
                table: "StockPrices");

            migrationBuilder.DropColumn(
                name: "stockExchangeid",
                table: "StockPrices");
        }
    }
}
