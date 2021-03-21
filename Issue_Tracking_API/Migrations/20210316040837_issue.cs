using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Issue_Tracking_API.Migrations
{
    public partial class issue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issue_Description = table.Column<string>(nullable: true),
                    Issue_Reporter_Name = table.Column<string>(nullable: true),
                    Issue_Reported_Date = table.Column<DateTime>(nullable: false),
                    Issue_Assignee_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueDetails", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScript", @"DataQueries.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueDetails");
        }
    }
}
