using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    IdAdress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAdress = table.Column<bool>(type: "bit", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.IdAdress);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    IdPhone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPhone = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.IdPhone);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    IdSuplier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComercialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IEST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.IdSuplier);
                });

            migrationBuilder.CreateTable(
                name: "SupplierAdresses",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false),
                    IdAdress = table.Column<int>(type: "int", nullable: false),
                    SupplierIdSuplier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierAdresses", x => new { x.IdSupplier, x.IdAdress });
                    table.ForeignKey(
                        name: "FK_SupplierAdresses_Addresses_IdAdress",
                        column: x => x.IdAdress,
                        principalTable: "Addresses",
                        principalColumn: "IdAdress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierAdresses_Suppliers_SupplierIdSuplier",
                        column: x => x.SupplierIdSuplier,
                        principalTable: "Suppliers",
                        principalColumn: "IdSuplier");
                });

            migrationBuilder.CreateTable(
                name: "SupplierPhones",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false),
                    IdPhone = table.Column<int>(type: "int", nullable: false),
                    PhoneIdPhone = table.Column<int>(type: "int", nullable: false),
                    SupplierIdSuplier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPhones", x => new { x.IdSupplier, x.IdPhone });
                    table.ForeignKey(
                        name: "FK_SupplierPhones_Phones_PhoneIdPhone",
                        column: x => x.PhoneIdPhone,
                        principalTable: "Phones",
                        principalColumn: "IdPhone",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierPhones_Suppliers_SupplierIdSuplier",
                        column: x => x.SupplierIdSuplier,
                        principalTable: "Suppliers",
                        principalColumn: "IdSuplier");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAdresses_IdAdress",
                table: "SupplierAdresses",
                column: "IdAdress");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAdresses_SupplierIdSuplier",
                table: "SupplierAdresses",
                column: "SupplierIdSuplier");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPhones_PhoneIdPhone",
                table: "SupplierPhones",
                column: "PhoneIdPhone");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPhones_SupplierIdSuplier",
                table: "SupplierPhones",
                column: "SupplierIdSuplier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierAdresses");

            migrationBuilder.DropTable(
                name: "SupplierPhones");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
