using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookSwap.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class usernamemaxlength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailOrUserName",
                table: "Employees",
                type: "NVarChar(72)",
                maxLength: 72,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarChar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailOrUserName",
                table: "Employees",
                type: "NVarChar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarChar(72)",
                oldMaxLength: 72);
        }
    }
}
