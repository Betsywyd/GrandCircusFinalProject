using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhatIsForDinnerBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class WhatIsForDinner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ingredientAmount",
                table: "SavedRecipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ingredientAmount",
                table: "SavedRecipe",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: true);
        }
    }
}
