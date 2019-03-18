using Microsoft.EntityFrameworkCore.Migrations;

namespace YancyAPI.Migrations
{
    public partial class FeaturesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO features VALUES ('Lane-Assistant')");
            migrationBuilder.Sql("INSERT INTO features VALUES ('Blind Spot Detection')");
            migrationBuilder.Sql("INSERT INTO features VALUES ('Headet Seats')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM features");
        }
    }
}
