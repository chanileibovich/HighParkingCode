using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HighParking.Data.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "custommerList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Credit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custommerList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DwellTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Credit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoicingId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "invoicinglist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerType = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    parkingDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoicinglist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invoicinglist_custommerList_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "custommerList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_invoicinglist_DetailsList_parkingDetailsId",
                        column: x => x.parkingDetailsId,
                        principalTable: "DetailsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_invoicinglist_CustomerId",
                table: "invoicinglist",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_invoicinglist_parkingDetailsId",
                table: "invoicinglist",
                column: "parkingDetailsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoicinglist");

            migrationBuilder.DropTable(
                name: "custommerList");

            migrationBuilder.DropTable(
                name: "DetailsList");
        }
    }
}
