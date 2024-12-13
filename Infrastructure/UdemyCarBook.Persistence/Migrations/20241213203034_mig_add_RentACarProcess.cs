using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_RentACarProcess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerMail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentACarProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    PickUpLocationID = table.Column<int>(type: "int", nullable: false),
                    DropOffLocationID = table.Column<int>(type: "int", nullable: false),
                    PickUpDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DropOffDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PickUpTİme = table.Column<TimeOnly>(type: "time", nullable: false),
                    DropOffTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PickUpDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DropOffDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACarProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentACarProcesses_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACarProcesses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcesses_CarID",
                table: "RentACarProcesses",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcesses_CustomerId",
                table: "RentACarProcesses",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACarProcesses");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
