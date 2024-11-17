﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sipos_Vlad_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AuthorsClass2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
