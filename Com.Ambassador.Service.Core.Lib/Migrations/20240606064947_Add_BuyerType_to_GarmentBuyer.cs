using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Core.Lib.Migrations
{
    public partial class Add_BuyerType_to_GarmentBuyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerType",
                table: "GarmentBuyers",
                maxLength: 50,
                nullable: true);

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "BuyerType",
                table: "GarmentBuyers");
        }
    }
}
