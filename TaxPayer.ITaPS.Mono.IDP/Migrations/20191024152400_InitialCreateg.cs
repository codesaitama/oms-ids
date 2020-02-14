using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxPayer.ITaPS.Mono.IDP.Migrations
{
    public partial class InitialCreateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dCreateDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "iStatus",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "iUser",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dCreateDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "iStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "iUser",
                table: "AspNetUsers");
        }
    }
}
