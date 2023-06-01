using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class AddPatronToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "checked_out_by_id",
                table: "books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_books_checked_out_by_id",
                table: "books",
                column: "checked_out_by_id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_patrons_checked_out_by_id",
                table: "books",
                column: "checked_out_by_id",
                principalTable: "patrons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_books_patrons_checked_out_by_id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "ix_books_checked_out_by_id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "checked_out_by_id",
                table: "books");
        }
    }
}
