using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, ".NET is a free and open source framework for Windows, Linux and macOS operating systems. It is an open source successor to the .NET Framework. The project is primarily developed by Microsoft and released under the MIT License.", "https://dotnet.microsoft.com/blob-assets/images/e-books/blazor-for-web-forms-devs.png", 100m, "dotNet" },
                    { 2, "C# is a strongly typed, multiparadigm programming language developed by Microsoft as part of the .NET platform. Its object-oriented syntax was based on C++ but includes many influences from other programming languages, such as Object Pascal and, mainly, Java.", "https://cdn.syncfusion.com/content/images/downloads/ebook/ebook-cover/C-sharp-Succinctly-Updated-1.png", 100m, "C#" },
                    { 3, "Blazor is a free and open source web framework that allows developers to build web apps using C# and HTML. It is being developed by Microsoft.", "https://cdn.syncfusion.com/content/images/downloads/ebook/ebook-cover/blazor-succinctly.png", 100m, "Blazor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
