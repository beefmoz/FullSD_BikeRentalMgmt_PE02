using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRentalMgmt2.Server.Data.Migrations
{
    public partial class AddDataBikeStaffBranchCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "BranchAddr", "BranchContact", "ManagerID" },
                values: new object[,]
                {
                    { 1, "Changi Coastal", "61234098", null },
                    { 2, "East Coast Park", "61255098", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustAddr", "CustContact", "CustEmail", "CustName" },
                values: new object[,]
                {
                    { 1, "Simei", "91234567", "amozlow888@gmail.com", "Amoz" },
                    { 2, "Sengkang", "91234568", "Dead_Pixelz@gmail.com", "Hou Sheng" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "StaffAddr", "StaffBranchID", "StaffContact", "StaffEmail", "StaffName", "StaffPos" },
                values: new object[,]
                {
                    { 1, "Simei", null, "81234567", "Lea819@hotmail.com", "Lea", "Counter" },
                    { 2, "Simei", 1, "81234568", "andrews09@hotmail.com", "Andrew", "Branch Manager" },
                    { 3, "Orchard", 2, "81235468", "benben09@hotmail.com", "Benjamin", "Branch Manager" }
                });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "BikeBranchID", "BikeModel", "BikeSize", "BikeType" },
                values: new object[] { 1, 1, "BMW", "Small", "Mountain" });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "BikeBranchID", "BikeModel", "BikeSize", "BikeType" },
                values: new object[] { 2, 2, "NeoRider", "Medium", "Mountain" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
