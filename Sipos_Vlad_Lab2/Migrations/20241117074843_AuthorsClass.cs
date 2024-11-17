using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sipos_Vlad_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AuthorsClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publisher_Author_AuthorID",
                table: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Publisher_AuthorID",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Publisher");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_AuthorID",
                table: "Author",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Author_AuthorID",
                table: "Author",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Author_AuthorID",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_AuthorID",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Author");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Publisher",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_AuthorID",
                table: "Publisher",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Publisher_Author_AuthorID",
                table: "Publisher",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID");
        }
    }
}
