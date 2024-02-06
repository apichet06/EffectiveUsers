using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveUsers.Migrations
{
    /// <inheritdoc />
    public partial class updateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveUpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EffectiveUpdateDate",
                table: "Users");
        }
    }
}
