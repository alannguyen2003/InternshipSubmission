using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessObjects.Migrations
{
    /// <inheritdoc />
    public partial class AddTableSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderNo",
                table: "tbl_DM_San_Pham",
                newName: "Thu_Tu");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "tbl_DM_San_Pham",
                newName: "Ghi_Chu");

            migrationBuilder.CreateTable(
                name: "tbl_DM_NCC",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma_NCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten_NCC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_NCC", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_NCC");

            migrationBuilder.RenameColumn(
                name: "Thu_Tu",
                table: "tbl_DM_San_Pham",
                newName: "OrderNo");

            migrationBuilder.RenameColumn(
                name: "Ghi_Chu",
                table: "tbl_DM_San_Pham",
                newName: "Notes");
        }
    }
}
