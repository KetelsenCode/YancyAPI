using Microsoft.EntityFrameworkCore.Migrations;

namespace YancyAPI.Migrations
{
    public partial class DatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Brands VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO Brands VALUES ('Skoda')");
            migrationBuilder.Sql("INSERT INTO Brands VALUES ('Fiat')");
            migrationBuilder.Sql("INSERT INTO Models VALUES ('Ford-Focus',(SELECT Id FROM Brands WHERE name = 'Ford'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES ('Skoda-Octavia',(SELECT Id FROM Brands WHERE name = 'Skoda'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES ('Skoda-Citigo',(SELECT Id FROM Brands WHERE name = 'Ford'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES ('Fiat-Panda',(SELECT Id FROM Brands WHERE name = 'Fiat'))");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM brands");
        }
    }
}
