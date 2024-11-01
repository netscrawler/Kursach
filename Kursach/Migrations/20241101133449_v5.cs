using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursach.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_admins_AdminId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_doctors_DoctorId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_AdminId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_DoctorId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "doctors",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "admins",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_UserId",
                table: "doctors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_admins_UserId",
                table: "admins",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_admins_users_UserId",
                table: "admins",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_users_UserId",
                table: "doctors",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_users_UserId",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_users_UserId",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_UserId",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_admins_UserId",
                table: "admins");

            migrationBuilder.AddColumn<Guid>(
                name: "AdminId",
                table: "users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "doctors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "admins",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_users_AdminId",
                table: "users",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_users_DoctorId",
                table: "users",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_admins_AdminId",
                table: "users",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_doctors_DoctorId",
                table: "users",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id");
        }
    }
}
