using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursach.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseProcedure");

            migrationBuilder.DropTable(
                name: "DiseaseProcedure_Card");

            migrationBuilder.DropTable(
                name: "diseases");

            migrationBuilder.AddColumn<string[]>(
                name: "Diseases",
                table: "procedurecards",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diseases",
                table: "procedurecards");

            migrationBuilder.CreateTable(
                name: "diseases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseProcedure",
                columns: table => new
                {
                    DiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProceduresId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseProcedure", x => new { x.DiseaseId, x.ProceduresId });
                    table.ForeignKey(
                        name: "FK_DiseaseProcedure_diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseProcedure_procedures_ProceduresId",
                        column: x => x.ProceduresId,
                        principalTable: "procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseProcedure_Card",
                columns: table => new
                {
                    DiseasesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Procedure_CardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseProcedure_Card", x => new { x.DiseasesId, x.Procedure_CardId });
                    table.ForeignKey(
                        name: "FK_DiseaseProcedure_Card_diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseProcedure_Card_procedurecards_Procedure_CardId",
                        column: x => x.Procedure_CardId,
                        principalTable: "procedurecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseProcedure_ProceduresId",
                table: "DiseaseProcedure",
                column: "ProceduresId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseProcedure_Card_Procedure_CardId",
                table: "DiseaseProcedure_Card",
                column: "Procedure_CardId");
        }
    }
}
