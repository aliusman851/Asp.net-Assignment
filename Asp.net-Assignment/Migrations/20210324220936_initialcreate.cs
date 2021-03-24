using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_Assignment.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attendees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "organizers",
                columns: table => new
                {
                    OrganizerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizers", x => x.OrganizerID);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpotsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerID = table.Column<int>(type: "int", nullable: true),
                    AttendeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_events_attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_events_organizers_OrganizerID",
                        column: x => x.OrganizerID,
                        principalTable: "organizers",
                        principalColumn: "OrganizerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "myevents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeeID = table.Column<int>(type: "int", nullable: true),
                    EventID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myevents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_myevents_attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_myevents_events_EventID",
                        column: x => x.EventID,
                        principalTable: "events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_events_AttendeeID",
                table: "events",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_events_OrganizerID",
                table: "events",
                column: "OrganizerID");

            migrationBuilder.CreateIndex(
                name: "IX_myevents_AttendeeID",
                table: "myevents",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_myevents_EventID",
                table: "myevents",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "myevents");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "attendees");

            migrationBuilder.DropTable(
                name: "organizers");
        }
    }
}
