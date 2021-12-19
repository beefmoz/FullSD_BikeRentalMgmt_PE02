using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRentalMgmt2.Server.Data.Migrations
{
    public partial class AddNameToUser_AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustAddr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffAddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffBranchID = table.Column<int>(type: "int", nullable: true),
                    StaffPos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchAddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Staff_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeBranchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bikes_Branches_BikeBranchID",
                        column: x => x.BikeBranchID,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentCustomerID = table.Column<int>(type: "int", nullable: false),
                    RentBikeID = table.Column<int>(type: "int", nullable: false),
                    RentBranchID = table.Column<int>(type: "int", nullable: false),
                    RentDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentOrders_Bikes_RentBikeID",
                        column: x => x.RentBikeID,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentOrders_Customers_RentCustomerID",
                        column: x => x.RentCustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentOrders_Branches_RentBranchID",
                        column: x => x.RentBranchID,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeBranchID",
                table: "Bikes",
                column: "BikeBranchID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ManagerID",
                table: "Branches",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrders_RentBikeID",
                table: "RentOrders",
                column: "RentBikeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentOrders_RentBranchID",
                table: "RentOrders",
                column: "RentBranchID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentOrders_RentCustomerID",
                table: "RentOrders",
                column: "RentCustomerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Branches_BranchID",
                table: "Staff",
                column: "StaffBranchID",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentOrders");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
