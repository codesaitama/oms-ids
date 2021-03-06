﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxPayer.ITaPS.Mono.IDP.Migrations
{
    public partial class NewlyAddedInitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserRegistrationGtapId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRegistrationGtapId",
                table: "AspNetUsers");
        }
    }
}
