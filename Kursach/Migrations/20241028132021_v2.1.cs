using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursach.Migrations
{
    /// <inheritdoc />
    public partial class v21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Procedure_CardId",
                table: "procedures",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_procedures_Procedure_CardId",
                table: "procedures",
                column: "Procedure_CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_procedures_procedurecards_Procedure_CardId",
                table: "procedures",
                column: "Procedure_CardId",
                principalTable: "procedurecards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_procedures_procedurecards_Procedure_CardId",
                table: "procedures");

            migrationBuilder.DropIndex(
                name: "IX_procedures_Procedure_CardId",
                table: "procedures");

            migrationBuilder.DropColumn(
                name: "Procedure_CardId",
                table: "procedures");
        }
    }
}
