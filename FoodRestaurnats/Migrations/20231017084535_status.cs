using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRestaurnats.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_foods_foodId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "foodId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_foods_foodId",
                table: "ShoppingCartItems",
                column: "foodId",
                principalTable: "foods",
                principalColumn: "foodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_foods_foodId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "foodId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_foods_foodId",
                table: "ShoppingCartItems",
                column: "foodId",
                principalTable: "foods",
                principalColumn: "foodId");
        }
    }
}
