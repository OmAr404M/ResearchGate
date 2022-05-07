using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResearchGate.Migrations
{
    public partial class UserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Authers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Authers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Authers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Authers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Authers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Authers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Authers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Authers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Authers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Authers");

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "Authers",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
