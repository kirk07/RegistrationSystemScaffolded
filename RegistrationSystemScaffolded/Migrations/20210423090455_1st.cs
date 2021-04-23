using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationSystemScaffolded.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Contact = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
