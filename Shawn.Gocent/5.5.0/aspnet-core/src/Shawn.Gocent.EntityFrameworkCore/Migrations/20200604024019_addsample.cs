using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shawn.Gocent.Migrations
{
    public partial class addsample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sample",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Col1 = table.Column<string>(nullable: true),
                    Col2 = table.Column<string>(nullable: true),
                    Col3 = table.Column<string>(nullable: true),
                    Col4 = table.Column<string>(nullable: true),
                    Col5 = table.Column<string>(nullable: true),
                    Col6 = table.Column<string>(nullable: true),
                    Col7 = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sample");
        }
    }
}
