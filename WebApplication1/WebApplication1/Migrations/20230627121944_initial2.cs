using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    TripId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remaining_Seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.TripId);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserLoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserLoginId);
                });

            migrationBuilder.CreateTable(
                name: "Traveler",
                columns: table => new
                {
                    TravelerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveler", x => x.TravelerId);
                    table.ForeignKey(
                        name: "FK_Traveler_Trip_TripId",
                        column: x => x.TripId,
                        principalTable: "Trip",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "TripId", "Date", "Name", "Price", "Remaining_Seats" },
                values: new object[,]
                {
                    { "B", new DateTime(2023, 7, 2, 2, 0, 0, 0, DateTimeKind.Unspecified), "Bethlehem", "500$", 10 },
                    { "C", new DateTime(2023, 7, 15, 5, 0, 0, 0, DateTimeKind.Unspecified), "Jericho", "800$", 7 },
                    { "J", new DateTime(2023, 8, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), "Jerusalem", "600$", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLogin",
                columns: new[] { "UserLoginId", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "Ahmad@123", "123" },
                    { 2, "Mohammad@123", "123" }
                });

            migrationBuilder.InsertData(
                table: "Traveler",
                columns: new[] { "TravelerId", "Age", "Email", "Name", "Seats", "TripId" },
                values: new object[,]
                {
                    { 1, 20, "Ahmad@gmail.com", "Ahmad Yahya", 2, "B" },
                    { 2, 20, "Mohammad@gmail.com", "Mohammad Mansour", 1, "J" },
                    { 3, 20, "Dunia@gmail.com", "Dunia Abdeljabbar", 3, "C" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Traveler_TripId",
                table: "Traveler",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traveler");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "Trip");
        }
    }
}
