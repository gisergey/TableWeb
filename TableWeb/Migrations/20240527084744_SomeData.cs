using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TableWeb.Migrations
{
    /// <inheritdoc />
    public partial class SomeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dataTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dataTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dataTable",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
