using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_TblUser_UserId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "TblTransaction");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_UserId",
                table: "TblTransaction",
                newName: "IX_TblTransaction_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblTransaction",
                table: "TblTransaction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblTransaction_TblUser_UserId",
                table: "TblTransaction",
                column: "UserId",
                principalTable: "TblUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblTransaction_TblUser_UserId",
                table: "TblTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblTransaction",
                table: "TblTransaction");

            migrationBuilder.RenameTable(
                name: "TblTransaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_TblTransaction_UserId",
                table: "Transactions",
                newName: "IX_Transactions_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_TblUser_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "TblUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
