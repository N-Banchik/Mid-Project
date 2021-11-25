using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class newitemorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderitems",
                table: "Orderitems");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Orderitems",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Orderitems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderitems",
                table: "Orderitems",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orderitems_Order_id",
                table: "Orderitems",
                column: "Order_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderitems",
                table: "Orderitems");

            migrationBuilder.DropIndex(
                name: "IX_Orderitems_Order_id",
                table: "Orderitems");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Orderitems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orderitems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderitems",
                table: "Orderitems",
                columns: new[] { "Order_id", "Itme_Id" });
        }
    }
}
