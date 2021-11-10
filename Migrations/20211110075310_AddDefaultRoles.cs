using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9001fdb-2301-433c-a101-a0744d313092", "0bc4193b-87fb-4e06-a940-0eeb38153926", "User", "USER" },
                    { "83abcbce-db09-4cbe-8031-dfbdeb0e2adc", "2a3d19b0-aad7-4c74-9fbe-fa4d37ba244d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortName",
                value: "JN");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Rating" },
                values: new object[] { "Grand palldium", 4.2999999999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83abcbce-db09-4cbe-8031-dfbdeb0e2adc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9001fdb-2301-433c-a101-a0744d313092");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortName",
                value: "JM");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Rating" },
                values: new object[] { "Grand Palladium", 4.0 });
        }
    }
}
