using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursach.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cabinets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Open = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Close = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Weekend = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cabinets", x => x.Id);
                });

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
                name: "pacients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Snils = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    Phone = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "procedures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedures", x => x.Id);
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
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Snils = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    Phone = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Snils = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    Phone = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "procedure_Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Zhalobi = table.Column<string[]>(type: "text[]", nullable: false),
                    PacientId = table.Column<Guid>(type: "uuid", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedure_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_procedure_Cards_doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_procedure_Cards_pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "procedures_Histories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedures_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_procedures_Histories_procedure_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "procedure_Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedureProcedures_History",
                columns: table => new
                {
                    ProceduresId = table.Column<Guid>(type: "uuid", nullable: false),
                    Procedures_HistoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureProcedures_History", x => new { x.ProceduresId, x.Procedures_HistoryId });
                    table.ForeignKey(
                        name: "FK_ProcedureProcedures_History_procedures_Histories_Procedures~",
                        column: x => x.Procedures_HistoryId,
                        principalTable: "procedures_Histories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcedureProcedures_History_procedures_ProceduresId",
                        column: x => x.ProceduresId,
                        principalTable: "procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Snils = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    Phone = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<byte[]>(type: "bytea", nullable: false),
                    AdminId = table.Column<Guid>(type: "uuid", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: false),
                    NurseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "nurses",
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

            migrationBuilder.CreateIndex(
                name: "IX_procedure_Cards_DoctorId",
                table: "procedure_Cards",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_procedure_Cards_PacientId",
                table: "procedure_Cards",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedureProcedures_History_Procedures_HistoryId",
                table: "ProcedureProcedures_History",
                column: "Procedures_HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_procedures_Histories_CardId",
                table: "procedures_Histories",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AdminId",
                table: "User",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DoctorId",
                table: "User",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_NurseId",
                table: "User",
                column: "NurseId");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_User_Id",
                table: "admins",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseProcedure_Card_procedure_Cards_Procedure_CardId",
                table: "DiseaseProcedure_Card",
                column: "Procedure_CardId",
                principalTable: "procedure_Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_User_Id",
                table: "doctors",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nurses_User_Id",
                table: "nurses",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_User_Id",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_User_Id",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_nurses_User_Id",
                table: "nurses");

            migrationBuilder.DropTable(
                name: "cabinets");

            migrationBuilder.DropTable(
                name: "DiseaseProcedure");

            migrationBuilder.DropTable(
                name: "DiseaseProcedure_Card");

            migrationBuilder.DropTable(
                name: "ProcedureProcedures_History");

            migrationBuilder.DropTable(
                name: "diseases");

            migrationBuilder.DropTable(
                name: "procedures_Histories");

            migrationBuilder.DropTable(
                name: "procedures");

            migrationBuilder.DropTable(
                name: "procedure_Cards");

            migrationBuilder.DropTable(
                name: "pacients");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "nurses");
        }
    }
}
