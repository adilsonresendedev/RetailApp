using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.IdAdress);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    IdPhone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPhone = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.IdPhone);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComercialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IEST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRT = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.IdSupplier);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "SupplierAdresses",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false),
                    IdAdress = table.Column<int>(type: "int", nullable: false),
                    IdSupplierAdress = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierAdresses", x => new { x.IdSupplier, x.IdAdress });
                    table.ForeignKey(
                        name: "FK_SupplierAdresses_Adresses_IdAdress",
                        column: x => x.IdAdress,
                        principalTable: "Adresses",
                        principalColumn: "IdAdress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierAdresses_Suppliers_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "Suppliers",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPhones",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false),
                    IdPhone = table.Column<int>(type: "int", nullable: false),
                    PhoneIdPhone = table.Column<int>(type: "int", nullable: false),
                    SupplierIdSupplier = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_SupplierPhones_Suppliers_SupplierIdSupplier",
                        column: x => x.SupplierIdSupplier,
                        principalTable: "Suppliers",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAdresses_IdAdress",
                table: "SupplierAdresses",
                column: "IdAdress");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPhones_PhoneIdPhone",
                table: "SupplierPhones",
                column: "PhoneIdPhone");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPhones_SupplierIdSupplier",
                table: "SupplierPhones",
                column: "SupplierIdSupplier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierAdresses");

            migrationBuilder.DropTable(
                name: "SupplierPhones");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
