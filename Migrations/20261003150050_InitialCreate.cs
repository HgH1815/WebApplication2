using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Number);
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Number", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "/images/Jack.png", "Jack" },
                    { 2, "/images/John.png", "John" },
                    { 3, "/images/Jimmy.png", "Jimmy" },
                    { 4, "/images/James.png", "James" },
                    { 5, "/images/Jones.png", "Jones" },
                    { 6, "/images/Jonathan.png", "Jonathan" },
                    { 7, "/images/Jakob.png", "Jakob" },
                    { 8, "/images/Jakline.png", "Jakline" },
                    { 9, "/images/Jashoa.png", "Jashoa" },
                    { 10, "/images/Jenifer.png", "Jenifer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");
        }
    }
}
