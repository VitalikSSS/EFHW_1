using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_1.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateofDirth",
                table: "USers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofDirth",
                table: "USers");
        }
    }
}
