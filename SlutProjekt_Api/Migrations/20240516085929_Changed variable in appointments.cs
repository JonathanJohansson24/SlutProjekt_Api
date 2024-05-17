using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlutProjekt_Api.Migrations
{
    /// <inheritdoc />
    public partial class Changedvariableinappointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDuration",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentDurationMinutes",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDurationMinutes",
                table: "Appointments");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AppointmentDuration",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
