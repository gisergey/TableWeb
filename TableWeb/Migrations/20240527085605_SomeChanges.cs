using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TableWeb.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dataTable");

            migrationBuilder.CreateTable(
                name: "dataWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataWords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "dataWords",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Большое круглое днем на небе весит", "Солнце" },
                    { 2, "Большое не всегда круглое ночью на небе иногда висит", "Луна" },
                    { 3, "Паралелепипед с буквами и бумагой", "Книга" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dataWords");

            migrationBuilder.CreateTable(
                name: "dataTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "dataTable",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Большое круглое днем на небе весит", "Солнце" },
                    { 2, "Большое не всегда круглое ночью на небе иногда висит", "Луна" },
                    { 3, "Паралелепипед с буквами и бумагой", "Книга" }
                });
        }
    }
}
