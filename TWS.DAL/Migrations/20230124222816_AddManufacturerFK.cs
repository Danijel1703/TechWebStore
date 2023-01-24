using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TWS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddManufacturerFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Manufacturer_ManufacturerId",
                table: "Product",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Manufacturer_ManufacturerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Product");
        }
    }
}
