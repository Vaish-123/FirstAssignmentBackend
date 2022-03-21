using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAssignment.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerTB",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerTB", x => x.Cid);
                });

            migrationBuilder.CreateTable(
                name: "productTB",
                columns: table => new
                {
                    ProdKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid = table.Column<int>(type: "int", nullable: false),
                    Pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pprice = table.Column<int>(type: "int", nullable: false),
                    Pquantity = table.Column<int>(type: "int", nullable: false),
                    Pamount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTB", x => x.ProdKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerTB");

            migrationBuilder.DropTable(
                name: "productTB");
        }
    }
}
