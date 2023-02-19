﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SYS.Infrastructure.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companies_CompanyID",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companies_CompanyID",
                table: "Products",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companies_CompanyID",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companies_CompanyID",
                table: "Products",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "ID");
        }
    }
}
