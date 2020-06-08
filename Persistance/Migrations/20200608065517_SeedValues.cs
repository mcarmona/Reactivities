﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new [] { "id", "Name" },
                values: new object[] { 1, "Value 101" }
            );

            migrationBuilder.InsertData(
                table: "Values",
                columns: new [] { "id", "Name" },
                values: new object[] { 2, "Value 102" }
            );

            migrationBuilder.InsertData(
                table: "Values",
                columns: new [] { "id", "Name" },
                values: new object[] { 3, "Value 103" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
